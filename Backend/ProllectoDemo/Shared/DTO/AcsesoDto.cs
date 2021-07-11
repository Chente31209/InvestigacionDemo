using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{ 
    public class AcsesoDto
    {
        public int Id { get; set; }
        public string NombreDeUsario { get; set; }
        public string Pasword { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}
