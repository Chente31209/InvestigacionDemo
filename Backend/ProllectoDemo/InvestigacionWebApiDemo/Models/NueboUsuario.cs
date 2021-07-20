using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestigacionWebApiDemo.Models
{
    public class NueboUsuario
    {
        [Required(ErrorMessage = "Nesecitas introducir una Nombre De Usario")]
        public string NombreDeUsarioOEmail { get; set; }
        [Required(ErrorMessage = "Nesecitas introducir una Pasword")]
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string E_Mail { get; set; }
        public string NumeroDeTelefono { get; set; }
        public DateTime FecaDeNacimento { get; set; }
        public string NombreDeLaOrgenisacion { get; set; }
        public string Giro { get; set; }
        public string Decripcion { get; set; }
        public string DescripcionDeTipoDeOregancion { get; set; }
    }
    public class Invitado
    {
        [Required(ErrorMessage = "Nesecitas introducir una Nombre De Usario")]
        public string NombreDeUsarioOEmail { get; set; }
        [Required(ErrorMessage = "Nesecitas introducir una Pasword")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nesecitas introducir una Codigo")]
        public string ClavedeInvitacion { get; set; }
        public string Nombre { get; set; }
        public string E_Mail { get; set; }
        public string NumeroDeTelefono { get; set; }
        public DateTime FecaDeNacimento { get; set; }
        
    }
}
