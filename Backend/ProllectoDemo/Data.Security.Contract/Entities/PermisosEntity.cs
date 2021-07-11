using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security.Contract.Entities
{
    public class PermisosEntity
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Decripcion { get; set; }
        public TipoDeCuentaEntity Id_tipoDeCuenta { get; set; }

    }
}
