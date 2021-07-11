using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bisnes.Security.Contract.Models;

namespace Bisnes.Security.Contract.InterfaceBines
{
    public interface ILogin
    {
        public ICollection<Acseso> Get();
    }
}
