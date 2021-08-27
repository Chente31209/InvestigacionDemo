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

        public List<Claim> GetClames(string Nombre)
        {
            List<Claim> Clames = new List<Claim> { };
            var list_Permisos = ususario.GetPermisos();
            var list_Tiene_Permisos = ususario.GetTienePermiosos();
            var list_Acseso = ususario.GetAcsesoEntities();

            var Acseo = list_Acseso.Where(x => x.NombreDeUsario == Nombre).FirstOrDefault().Usuario.Id_tipoDeCuenta.Id;
            var permisos = list_Tiene_Permisos.Where(x => x.Id_tipoDeCuenta.Id == Acseo).ToList();
            Clames.Add(new Claim(ClaimTypes.Name, Nombre));
            foreach (var i in permisos)
            {
                Clames.Add(new Claim(i.Id_permisos.Decripcion, i.Id_permisos.Tipo));
            }
            return Clames;
        }
    }
}
