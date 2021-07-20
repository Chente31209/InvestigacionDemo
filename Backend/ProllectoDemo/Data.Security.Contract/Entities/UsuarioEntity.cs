using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security.Contract.Entities
{
    public class UsuarioEntity
    {
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string E_Mail { get; set; }
        public string NumeroDeTelefono { get; set; }
        public DateTime FecaDeNacimento { get; set; }
        public OrganisacionEntity Id_organisacion { get; set; }
        public TipoDeCuentaEntity Id_tipoDeCuenta { get; set; }
    }
}
