using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;
using Bisnes.Security.Contract.InterfaceBines;

namespace InvestigacionWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILogin _login;
        public LoginController(ILogin login)
        {
            this._login = login;
        }
        [HttpPost]
        [Route("Login")]
        public IEnumerable<AcsesoDto> Logiin()
        {
            List<AcsesoDto> dtos = new List<AcsesoDto> { };
            foreach (var i in _login.Get())
            {
                dtos.Add(new AcsesoDto { Id = i.Id, NombreDeUsario = i.NombreDeUsario, Pasword = i.Pasword, Usuario = null });
            }
            return dtos;
        }
        [HttpGet]
        [Route("action")]
        public IEnumerable<AcsesoDto> Get()
        {
            List<AcsesoDto> dtos = new List<AcsesoDto> { };
            foreach (var i in _login.Get())
            {
                dtos.Add(new AcsesoDto { Id = i.Id, NombreDeUsario = i.NombreDeUsario, Pasword = i.Pasword, Usuario = null });
            }
            return dtos;
        }

    }
}
