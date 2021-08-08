using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Security.Contract.Entities;
using Data.Security.Contract.InterfacesDataLaibery;
namespace Data.Security
{
    public class LoginAhut :BaseDB , ILoginAhut 
    {
        public LoginAhut(SecurityDbContext db): base(db) { }
        public ICollection<AcsesoEntity> Get()
        {
            var p = db.Acsesos.ToList();
            var U = db.Usuarios.ToList();
            var O = db.TiposDeCuentas.ToList();
            var q = db.Organisaciones.ToList();
            var w = db.Permisos.ToList();
            var Or = db.TiposDeOraganisaciones.ToList();
            
        
            return p;
        }
    }
}
