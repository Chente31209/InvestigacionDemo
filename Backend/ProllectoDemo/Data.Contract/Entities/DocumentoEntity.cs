using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contract.Entities
{
    public class DocumentoEntity

    {
        public int id { get; set; }
        public string URL { get; set; }
        public UsuarioEntity id_Usuario { get; set; }
        public Tipo_DocuemntoEntity Id_Tipo { get; set; }
    }
}
