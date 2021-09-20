﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Shared.Autenticacion;

namespace DemoWebApiV1.Servises
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(bool Ecciste, Usuario usuario, List<Claim> ListaPermisis);
    }
}