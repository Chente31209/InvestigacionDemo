using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bines.Security.Contract.InterfaceBines
{
    public interface ILogUPNewUser
    {
        public void UPNewUsuario(string NombreDeUsarioOEmail ,
                                 string Password ,
                                 string Nombre ,
                                 string E_Mail ,
                                 string NumeroDeTelefono ,
                                 DateTime FecaDeNacimento ,
                                 string NombreDeLaOrgenisacion ,
                                 string Giro ,
                                 string Decripcion ,
                                 string DescripcionDeTipoDeOregancion );
        public void Invitado(string NombreDeUsario,
                                string Password,
                                string Nombre,
                                string E_Mail,
                                string NumeroDeTelefono,
                                DateTime FecaDeNacimento,
                                string ClaveInvitacion);
    }
    
}
