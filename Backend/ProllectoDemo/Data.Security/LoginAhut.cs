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
            return db.Acsesos.ToList();
        }
    }
}
