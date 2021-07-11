using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security.Contract.Entities
{
    public class TipoDeCuentaEntity
    {
        public int Id { get; set; }
        public string RolUsario { get; set; }
        public UsuarioEntity Usuario { get; set; }


    }
}
