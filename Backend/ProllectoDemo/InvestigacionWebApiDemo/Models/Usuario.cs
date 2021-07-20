using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestigacionWebApiDemo.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Nesecitas introducir una Nombre De Usario")]
        public string NombreDeUsarioOEmail { get; set; }
        [Required(ErrorMessage = "Nesecitas introducir una Pasword")]
        public string Password { get; set; }
}
}
