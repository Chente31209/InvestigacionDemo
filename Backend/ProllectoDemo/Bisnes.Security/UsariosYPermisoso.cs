using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bines.Security.Contract.InterfaceBines;
using Bisnes.Security.Contract.Models;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Bisnes.Security
{
    public class UsariosYPermisoso : IUsuarioBisnes
    {
        public readonly IUsusario ususario;
        public readonly IMapper imaper;
        public UsariosYPermisoso(IUsusario ususario, IMapper imaper)
        {
            
            this.ususario = ususario;
            this.imaper = imaper;
        }
        public List<Usuario> Get()
        {
            var list = ususario.GetUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var i in list)
                usuarios.Add(imaper.Map<Usuario>(i));
            return usuarios;
        }

        public List<Claim> GetClames()
        {
            List<Claim> Clames = new List<Claim> { };
            var list = ususario.GetUsuario();
            var list_Permisos = ususario.GetPermisos();
            var list_Tiene_Permisos = ususario.GetTienePermiosos();
            var list_tipo_de_uentas = ususario.GetTipoDeCuentas();

            return Clames;
        }
    }
}
