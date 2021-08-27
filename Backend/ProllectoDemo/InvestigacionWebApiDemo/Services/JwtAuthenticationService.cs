using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bines.Security.Contract.InterfaceBines;
using InvestigacionWebApiDemo.Models;
using Microsoft.IdentityModel.Tokens;

namespace InvestigacionWebApiDemo.Services
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly string _key;
        private readonly IUsuarioBisnes _usuarioBisnes;

        public JwtAuthenticationService(string key)
        {
            this._key = key;
          
        }

        public string Authenticate(bool Ecciste, Usuario usuario, List<Claim> ListaPermisis)
        {
            if (Ecciste)
            {

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes(_key);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(ListaPermisis),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }
            else
                return null;
        }
    }
}
