using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bisnes.Security.Contract.InterfaceBines;
using Bisnes.Security.Contract.Models;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Bisnes.Security
{
    public class Login : ILogin
    {
        private ILoginAhut _loginAhut;
        private  IMapper _mpper;

        public Login(ILoginAhut loginAhut, IMapper mpper)
        {
            this._loginAhut = loginAhut;
            this._mpper = mpper;
        }


        public IEnumerable<Acseso> Get()
        {
            var Lista = _loginAhut.Get();
            foreach(var i in Lista)
                yield return _mpper.Map<Acseso>(i);
        }
    }
}
