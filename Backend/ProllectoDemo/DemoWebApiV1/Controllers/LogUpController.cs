using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogUpController : ControllerBase
    {
        [HttpPost]
        public IActionResult LogUp(Regustro regustro)
        {
            return Ok();
        }
    }
}
