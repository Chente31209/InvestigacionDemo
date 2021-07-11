using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class TipoDeCuentaDto
    {
        public int Id { get; set; }
        public string RolUsario { get; set; }
        public UsuarioDto Usuario { get; set; }

    }
}
