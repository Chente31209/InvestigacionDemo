using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Security.Contract.Entities;

namespace Data.Security.Contract.InterfacesDataLaibery
{
    public interface ILoginAhut
    {
        public ICollection<AcsesoEntity> Get();
    }
}
