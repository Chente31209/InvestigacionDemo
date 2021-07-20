using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisnes.Security.Contract.Models
{
    public class Organisacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Giro { get; set; }
        public string Decripcion { get; set; }
        public string ClaveInvitacion { get; set; }
        public TipoDeOraganisacion Id_tipoDeOraganisacion { get; set; }
    }
}
