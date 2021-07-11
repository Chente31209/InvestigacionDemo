using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class OrganisacionDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Giro { get; set; }
        public string Decripcion { get; set; }
        public TipoDeOraganisacionDto Id_tipoDeOraganisacion { get; set; }
    }
}
