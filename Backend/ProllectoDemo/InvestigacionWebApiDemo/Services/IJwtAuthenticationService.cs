using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestigacionWebApiDemo.Models;

namespace InvestigacionWebApiDemo.Services
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(bool Ecciste,Usuario usuario);
    }
}
