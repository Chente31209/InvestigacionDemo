using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Security.Contract.Entities;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Data.Security
{
    public class LogUp : BaseDB, ILogUP
    {
        public LogUp(SecurityDbContext db) : base(db) { }

        public void UpNewUsuario(OrganisacionEntity organisacion, AcsesoEntity acseso, UsuarioEntity usuario, string DescripcionDeTipoDeOregancion)
        {
            var root = db.TiposDeCuentas.Where(x=>x.Id==1).FirstOrDefault();
            var tipoDeOraganisacion = db.TiposDeOraganisaciones.Where(x => x.Descripcion == DescripcionDeTipoDeOregancion).FirstOrDefault(); 
            organisacion.Id_tipoDeOraganisacion = tipoDeOraganisacion;
            usuario.Id_organisacion = organisacion;
            usuario.Id_tipoDeCuenta = root;
            acseso.Usuario = usuario;
            db.Organisaciones.Add(organisacion);
            db.Usuarios.Add(usuario);
            db.Acsesos.Add(acseso);
            db.SaveChanges();
        }

        public void UpNewUsuarioInvitado(AcsesoEntity acseso, UsuarioEntity usuario, string ClaveInvitacion)
        {
            var organicion = db.Organisaciones.Where(x => x.ClaveInvitacion == ClaveInvitacion).FirstOrDefault();
            var Tipo = db.TiposDeCuentas.Where(x => x.Id == 2).FirstOrDefault();
            usuario.Id_organisacion = organicion;
            usuario.Id_tipoDeCuenta = Tipo;
            acseso.Usuario = usuario;
            db.Usuarios.Add(usuario);
            db.Acsesos.Add(acseso);
            db.SaveChanges();
        }
    }
}

