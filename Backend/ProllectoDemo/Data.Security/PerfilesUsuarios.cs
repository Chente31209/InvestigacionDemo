using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Security.Contract.Entities;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Data.Security
{
    public class PerfilesUsuarios : BaseDB, IUsusario
    {
        public PerfilesUsuarios(SecurityDbContext db) : base(db) { }

        public List<AcsesoEntity> GetAcsesoEntities()
        {
            return db.Acsesos.ToList();
        }

        public List<PermisosEntity> GetPermisos()
        {
            return db.Permisos.ToList();
        }

        public List<TienePermiosoEntity> GetTienePermiosos()
        {
            return db.TienePermioso.ToList();
        }

        public List<TipoDeCuentaEntity> GetTipoDeCuentas()
        {
            return db.TiposDeCuentas.ToList();
        }

        public List<UsuarioEntity> GetUsuario()
        {
            return db.Usuarios.ToList();
        }
    }
}
