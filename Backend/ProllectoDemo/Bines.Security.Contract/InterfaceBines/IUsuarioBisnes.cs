using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bisnes.Security.Contract.Models;

namespace Bines.Security.Contract.InterfaceBines
{
    public interface IUsuarioBisnes
    {
        public List<Usuario> Get();
        public List<Claim> GetClames(string Nombre);
    }
}
