using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security.Contract.Entities
{
    public class AcsesoEntity
    {
       
        public int Id { get; set; }
        public string NombreDeUsario { get; set; }
        public string Pasword { get; set; }
        public UsuarioEntity Usuario { get; set; }
    }
}
