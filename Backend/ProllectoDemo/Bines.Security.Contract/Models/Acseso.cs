using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisnes.Security.Contract.Models
{ 
    public class Acseso
    {
        public int Id { get; set; }
        public string NombreDeUsario { get; set; }
        public string Pasword { get; set; }
        public Usuario Usuario { get; set; }
    }
}
