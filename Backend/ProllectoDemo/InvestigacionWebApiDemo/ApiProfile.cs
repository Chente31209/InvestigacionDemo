using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bisnes.Security.Contract.Models;
using Shared.DTO;

namespace InvestigacionWebApiDemo
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<AcsesoDto, Acseso>().ReverseMap();
            CreateMap<OrganisacionDto, Organisacion>().ReverseMap();
            CreateMap<Permisos, Permisos>().ReverseMap();
            CreateMap<TipoDeCuentaDto, TipoDeCuenta>().ReverseMap();
            CreateMap<TipoDeOraganisacionDto, TipoDeOraganisacion>().ReverseMap();
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
        }


    }
}
