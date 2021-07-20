using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;
using Bisnes.Security.Contract.InterfaceBines;
using AutoMapper;
using InvestigacionWebApiDemo.Models;
using Microsoft.Extensions.Logging;
using InvestigacionWebApiDemo.Services;
using Microsoft.AspNetCore.Authorization;

namespace InvestigacionWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _login;
        private readonly IMapper _mpper;
        private readonly ILogger<LoginController> _logger;
        private readonly IJwtAuthenticationService _authService;

        public LoginController(ILogger<LoginController> logger, IJwtAuthenticationService authService,ILogin login, IMapper mapper)
        {
            this._login = login;
            this._mpper = mapper;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _authService = authService;
        }
        /*[AllowAnonymous]
        [HttpGet]
        public object Get()
        {
            var responseObject = new { Status = "Running" };
            _logger.LogInformation($"Status: {responseObject.Status}");

            return responseObject;
        }*/
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public IActionResult  Logiin(Usuario usuario)
        {
            var list = _login.Get();
            bool result = false;
            foreach (var i in list)
            {
                if (i.NombreDeUsario == usuario.NombreDeUsarioOEmail)
                {
                    if (i.Pasword == usuario.Password)
                    {
                        result= true;
                        break;
                        
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    result = false;
                }
            }

            var token = _authService.Authenticate(result,usuario);

            if (token == null)
            {
                return Unauthorized("El Usario O el Pasword No Es Corecto");
            }

            return Ok(token);

        }
        
        //mantener porvicional mente Para Consultas 
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<AcsesoDto> GetUser()
        {
            var list = _login.Get();
            foreach (var i in list)
                yield return _mpper.Map<AcsesoDto>(i);
        }

    }
}
