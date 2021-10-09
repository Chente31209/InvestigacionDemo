using InvoicingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using ecodex.ws.model._2011.CFDI;
using In.src.Cliente._2011.CFDI;
using Inv.src.Seguridad._2011.CFDI;
using System.ServiceModel;
using ProcessCFDI.Utils;
using Microsoft.Extensions.Configuration;

namespace InvoicingLibrary.CFDIProviders
{
    public class EcodexProvider : ISATProvider
    {
        private IConfiguration _configuration;
        public EcodexProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string INTEGRATOR_ID => _configuration["INTEGRATION_ID"];
        public async Task<byte[]> ObtenerQR(string RFC, String UUID, long transactionId)
        {
            try
            {
                TimbradoClient client = new TimbradoClient();
                SolicitudObtenerQRTimbrado solicitud = new SolicitudObtenerQRTimbrado(RFC, ObtenerToken(RFC, transactionId),  transactionId, UUID);
                var response = await client.ObtenerQRTimbradoAsync(solicitud);
               
                return response.QR.Imagen;
            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaServicio> serviceFault)
            {
                throw new Exception(String.Format($"Error al timbrar  {serviceFault.Message} { serviceFault.Detail.Numero}"));
            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaSesion> serviceSesion)
            {
                throw new Exception(String.Format($"Error al timbrar { serviceSesion.Message}"));
            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaValidacion> faultvalidation)
            {
                throw new Exception(String.Format($"Error al timbrar {faultvalidation.Message}"));
            }
        }

        public String Timbrar(String RFC, String Comprobante, long transactionId)
        {
            try
            {
                //TimbradoClient.EndpointConfiguration = TimbradoClient.EndpointConfiguration.PuertoTimbradoSeguro;
                TimbradoClient client = new TimbradoClient(TimbradoClient.EndpointConfiguration.PuertoTimbradoSeguro, "https://pruebas.ecodex.com.mx:2045/ServicioTimbrado.svc?wsdl");
                ComprobanteXML commprobante = new ComprobanteXML();
                SolicitudTimbraXML solicitud = new SolicitudTimbraXML(commprobante, RFC, ObtenerToken(RFC, transactionId), transactionId);
                commprobante.DatosXML = Comprobante;
                var timbrado = client.TimbraXMLAsync(solicitud).Result;

                return timbrado.ComprobanteXML.DatosXML;
            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaServicio> serviceFault)
            {
                throw new Exception(String.Format("Error al timbrar  {0} {1}", serviceFault.Message, serviceFault.Detail.Numero));

            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaSesion> serviceSesion)
            {
                throw new Exception(String.Format("Error al timbrar {0}", serviceSesion.Message));
            }
            catch (FaultException<ecodex.ws.model._2011.CFDI.FallaValidacion> faultvalidation)
            {
                throw new Exception(String.Format("Error al timbrar {0}", faultvalidation.Message));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public   string ObtenerToken(string RFC, long transactionID)
        {
            SeguridadClient srv = new SeguridadClient(SeguridadClient.EndpointConfiguration.PuertoSeguridadSeguro);
            SolicitudObtenerToken solicitud = new SolicitudObtenerToken(RFC, transactionID);
            var serviceToken = srv.ObtenerTokenAsync(solicitud).Result;

            return ObtenerHash(serviceToken.Token.ToString());
            /*var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
            var token = Security.Hash(toHash);            
            return token;*/
        }

        public string ObtenerHash(string serviceToken)
        {
            var toHash = String.Format($"{INTEGRATOR_ID}|{serviceToken}");
            var token = Security.Hash(toHash);
            return token;
        }
    }
}
//Documentacion de COnfiguration
