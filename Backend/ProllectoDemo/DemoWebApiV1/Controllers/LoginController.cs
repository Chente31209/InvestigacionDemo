using DemoWebApiV1.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoWebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
      
        private readonly ILogger<LoginController> _logger;
        private readonly IJwtAuthenticationService _authService;
        

        public LoginController(ILogger<LoginController> logger, IJwtAuthenticationService authService)
        {
            
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _authService = authService;
            
        }


        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            bool result = false;
            
                if ("Juan" == usuario.NombreDeUsuario)
                {
                    if ("prueba123" == usuario.Password)
                        result = true;
                    else
                        result = false;
                }
                else
                    result = false;

            List<Claim> Roles = new List<Claim>() { new Claim(ClaimTypes.Name,usuario.NombreDeUsuario)};

            var token = _authService.Authenticate(result, usuario, Roles);

            if (token == null)
            {
                return Unauthorized("El Usario O el Pasword No Es Corecto");
            }

            return Ok(token);
        }
    }
}
