using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bines.Security.Contract.InterfaceBines;
using Bisnes.Security.Contract.Models;
using AutoMapper;
using Data.Security.Contract.Entities;
using Data.Security.Contract.InterfacesDataLaibery;

namespace Bisnes.Security
{
    public class LogUpNewUsuario : ILogUPNewUser
    {
        private readonly IMapper _mapper;
        private readonly ILogUP logUP;

        public LogUpNewUsuario(IMapper mapper, ILogUP logUP)
        {
            this._mapper = mapper;
            this.logUP = logUP;
        }

        public void Invitado(string NombreDeUsario, string Password, 
            string Nombre, string E_Mail, string NumeroDeTelefono, DateTime FecaDeNacimento,
            string ClaveInvitacion)
        {
            var acseso = new Acseso { NombreDeUsario = NombreDeUsario, Pasword = Password };
            var usuario = new Usuario { Nombre = Nombre, E_Mail = E_Mail, NumeroDeTelefono = NumeroDeTelefono, FecaDeNacimento = FecaDeNacimento };
            var AcsesoEItem = _mapper.Map<AcsesoEntity>(acseso);
            var UsuariEItem = _mapper.Map<UsuarioEntity>(usuario);
            logUP.UpNewUsuarioInvitado(AcsesoEItem, UsuariEItem, ClaveInvitacion);
        }

        public void UPNewUsuario(string NombreDeUsario, string Password, 
               string Nombre, string E_Mail, string NumeroDeTelefono, DateTime FecaDeNacimento, 
               string NombreDeLaOrgenisacion, string Giro, string Decripcion, 
               string DescripcionDeTipoDeOregancion)
        {
            var acseso = new Acseso{NombreDeUsario = NombreDeUsario,Pasword=Password };
            var usuario = new Usuario {Nombre=Nombre,E_Mail=E_Mail,NumeroDeTelefono=NumeroDeTelefono,FecaDeNacimento=FecaDeNacimento};
            var orgenicion = new Organisacion { Nombre = NombreDeLaOrgenisacion, Giro = Giro, Decripcion = Decripcion };

            var AcsesoEItem = _mapper.Map<AcsesoEntity>(acseso);
            var UsuariEItem = _mapper.Map<UsuarioEntity>(usuario);
            var OreganisacionEItem = _mapper.Map<OrganisacionEntity>(orgenicion);
            logUP.UpNewUsuario(OreganisacionEItem, AcsesoEItem, UsuariEItem, DescripcionDeTipoDeOregancion);
        }
    }
}
