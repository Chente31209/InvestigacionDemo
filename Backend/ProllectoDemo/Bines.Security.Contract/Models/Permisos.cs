﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisnes.Security.Contract.Models
{
    public class Permisos
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Decripcion { get; set; }
        public TipoDeCuenta Id_tipoDeCuenta { get; set; }

    }
}