using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;
using InvoicingLibrary.CFDI;
using InvoicingLibrary.Interfaces;
using InvoicingLibrary.CFDIProviders;
using InvoicingLibrary.Certifcate;
using InvoicingLibrary.BindingModels;
using Microsoft.AspNetCore.Authorization;


namespace DemoWebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public InvoicingLibrary.BindingModels.Comprobante _testComprobante;
        public InvoicingLibrary.Interfaces.ICertificatesRepository _MockRepository;
        public InvoicingLibrary.Interfaces.IInvoicingRepository _MoInvoicingRepository;
        public InvoicingLibrary.Interfaces.ISATProvider _moqSatProvider;
        private Microsoft.Extensions.Configuration.IConfiguration configuration;

        [HttpPost]
        public void Comprobante(Comprobante comprobante)
        {
            string SerieBase = comprobante.Folio;
            
            _MockRepository = Substitute.For<ICertificatesRepository>();
            _MockRepository.GetCertificate(comprobante.noCertificado).ReturnsForAnyArgs(new CertificateMoq());
            _MoInvoicingRepository = Substitute.For<IInvoicingRepository>();
            //EcodexProvider
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            _moqSatProvider = new EcodexProvider(configuration);
            var cfdiController = new CFDIv33(_MockRepository, _moqSatProvider);
            var xmlComprobante = cfdiController.CreateCFDI(comprobante);
            Console.WriteLine(xmlComprobante);
        }

        [HttpGet]
        public String Get()
        {
            _MockRepository = Substitute.For<ICertificatesRepository>();
            _MockRepository.GetCertificate("30001000000400002321").ReturnsForAnyArgs(new CertificateMoq());

            _MoInvoicingRepository = Substitute.For<IInvoicingRepository>();
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _moqSatProvider = new EcodexProvider(configuration);

            _testComprobante = new InvoicingLibrary.BindingModels.Comprobante()
            {
                Version = "3.3",
                Fecha = DateTime.Now,
                Emisor = new InvoicingLibrary.BindingModels.Emisor()
                {
                    Nombre = "Juan perez",
                    RegimenFiscal = "611",
                    RFC = "FUNK671228PH6"
                },
                Receptor = new InvoicingLibrary.BindingModels.Receptor()
                {
                    Nombre = "Pepe perez",
                    RFC = "MISC491214B86",
                },
                Conceptos = new System.Collections.Generic.List<InvoicingLibrary.BindingModels.Concepto>()
                {
                    new InvoicingLibrary.BindingModels.Concepto()
                    {
                            Cantidad = 100,
                            ClaveProductoServicio = "01010101",
                            ClaveUnidad = "M55",
                            Descripcion = "Una madre aqui sin impuestos",
                            Importe = 20000,
                            Unidad = "Radianes",
                            ValorUnitario = 200,
                            ConceptosImpuestos = new System.Collections.Generic.List<InvoicingLibrary.BindingModels.ConceptoImpuestos>()
                            {
                                new InvoicingLibrary.BindingModels.ConceptoImpuestos()
                                {
                                    BaseImpuesto = 20000,
                                    Importe = 3200,
                                    Impuesto =  "IVA",
                                    RetencionOTraslado = "Traslado",
                                    TasaOCuota = "0.16",
                                    TipoFactor =  "Tasa"
                                }
                            }
                    },

                }
                ,


                LugarExpedicion = "99100",
                FormaPago = "01",
                MetodoPago = "PUE",
                TipoComprobante = "I",
                CondicionesDePago = "Pago al contado",
                SubTotal = 20000,
                Total = 23200,
                Moneda = "MXN",
                noCertificado = "30001000000400002321",
                UsoCFDI = "G01"
            };


            var cfdiController = new CFDIv33(_MockRepository, _moqSatProvider);
            var xmlComprobante = cfdiController.CreateCFDI(_testComprobante);
            return xmlComprobante;
        }
        /*--------*/
    }
}
