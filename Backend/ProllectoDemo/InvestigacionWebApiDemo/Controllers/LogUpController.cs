using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestigacionWebApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bines.Security.Contract.InterfaceBines;


namespace InvestigacionWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogUpController : ControllerBase
    {
        private readonly ILogUPNewUser logUP;

        public LogUpController(ILogUPNewUser logUP)
        {
            this.logUP = logUP;
        }
        [HttpPost]
        [Route("LogUp")]
        public IActionResult LogUP(NueboUsuario nueboUsuario)
        {
            try
            {
                logUP.UPNewUsuario(nueboUsuario.NombreDeUsarioOEmail, nueboUsuario.Password,
                nueboUsuario.Nombre, nueboUsuario.E_Mail, nueboUsuario.NumeroDeTelefono, nueboUsuario.FecaDeNacimento, nueboUsuario.NombreDeLaOrgenisacion
                , nueboUsuario.Giro, nueboUsuario.Decripcion, nueboUsuario.DescripcionDeTipoDeOregancion);
                return Ok("Registrado Con exito");

            }
            catch(Exception e)
            {
                return Unauthorized(e.Message);
            }
        }

        [HttpPost]
        [Route("LogUpInvitado")]
        public IActionResult LogUPInvitado(Invitado nueboUsuario)
        {
            try
            {

                logUP.Invitado(nueboUsuario.NombreDeUsarioOEmail, nueboUsuario.Password,
                nueboUsuario.Nombre, nueboUsuario.E_Mail, nueboUsuario.NumeroDeTelefono, nueboUsuario.FecaDeNacimento, nueboUsuario.ClavedeInvitacion);
                return Ok();
            }
            catch (Exception e)
            {
                return Unauthorized(e.Message);
            }


        }
    }
}
