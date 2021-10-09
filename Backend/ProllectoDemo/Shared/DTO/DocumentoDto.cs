using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class DocumentoDto
    {
        public int id { get; set; }
        public string URL { get; set; }
        public UsuarioDto id_Usuario { get; set; }
        public Tipo_DocuemntoDto Id_Tipo { get; set; }
    }
}
