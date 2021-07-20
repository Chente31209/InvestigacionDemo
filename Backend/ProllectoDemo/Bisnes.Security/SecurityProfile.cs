using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bisnes.Security.Contract.Models;
using Data.Security.Contract.Entities;

namespace Bisnes.Security
{
    public class SecurityProfile : Profile
    {
        public SecurityProfile()
        {
            CreateMap<Acseso, AcsesoEntity>().ReverseMap();
            CreateMap< Organisacion, OrganisacionEntity>().ReverseMap();
            CreateMap<Permisos, PermisosEntity>().ReverseMap();
            CreateMap<TipoDeCuenta, TipoDeCuentaEntity>().ReverseMap();
            CreateMap<TipoDeOraganisacion, TipoDeOraganisacionEntity>().ReverseMap();
            CreateMap<Usuario, UsuarioEntity>().ReverseMap();

        }
    }
}
