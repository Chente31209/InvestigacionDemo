using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bisnes.Security.Contract.InterfaceBines;
using Bisnes.Security.Contract.Models;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Bisnes.Security
{
    public class Login : ILogin
    {
        private ILoginAhut _loginAhut;
        public Login(ILoginAhut loginAhut)
        {
            this._loginAhut = loginAhut;
        }


        public ICollection<Acseso> Get()
        {
            List<Acseso> Lista = new List<Acseso>();
            foreach (var i in _loginAhut.Get())
            {
                Lista.Add(new Acseso { Id = i.Id, NombreDeUsario = i.NombreDeUsario, Pasword = i.Pasword, Usuario = null }); 
            }
            return Lista;
        }
    }
}
