using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Security.Contract.Entities;

namespace Data.Security.Contract.InterfacesDataLaibery
{
    public interface ILogUP
    {
        public void UpNewUsuario(OrganisacionEntity organisacion, AcsesoEntity acseso, UsuarioEntity usuario, string DescripcionDeTipoDeOregancion);
        public void UpNewUsuarioInvitado(AcsesoEntity acseso, UsuarioEntity usuario, string ClaveInvitacion);


    }
}
