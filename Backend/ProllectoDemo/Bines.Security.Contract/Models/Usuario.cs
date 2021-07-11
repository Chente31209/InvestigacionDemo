﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisnes.Security.Contract.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string E_Mail { get; set; }
        public int NumeroDeTelefono { get; set; }
        public DateTime FecaDeNacimento { get; set; }
        public Organisacion Id_organisacion { get; set; }
    }
}
