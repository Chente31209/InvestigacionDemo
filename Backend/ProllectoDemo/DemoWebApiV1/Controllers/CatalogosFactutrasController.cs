using ItemsDemoFactura;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosFactutrasController : ControllerBase
    {
       [HttpGet]
       [Route("/CFDI")]
        public List<FormaDePagoCatalogo> Cfdis()
        {
            return Catalogos.GetCfdis();
        }


        [HttpGet]
        [Route("/Forma")]
        public List<CFDICatalogo> FormaDePagos()
        {
            return Catalogos.GetFormasDePagos();
        }

        [HttpGet]
        [Route("/Metodo")]
        public  List<MetodoDePago> GetMetosoDePagos()
        {
            return Catalogos.GetMetosoDePagos();
        }

       
        [HttpGet]
        [Route("/Condiciones")]
        public  List<string> GetCondicionesDePago()
        {
            return Catalogos.GetCondicionesDePago();
        }
    }
}
