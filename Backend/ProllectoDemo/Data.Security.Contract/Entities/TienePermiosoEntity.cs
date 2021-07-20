﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security.Contract.Entities
{
    public class TienePermiosoEntity
    {
       
        public int Id { get; set; } 
        public TipoDeCuentaEntity Id_tipoDeCuenta { get; set; }
        public PermisosEntity Id_permisos { get; set; }
    }
}