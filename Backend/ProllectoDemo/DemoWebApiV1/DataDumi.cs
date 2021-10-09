using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.DTO;

namespace DemoWebApiV1
{
    public static class DataDumi
    {
        public static List<UsuarioDto> Perfiles()
        {
            return new List<UsuarioDto>
            {
                new UsuarioDto
                {
                    Id=1,
                    E_Mail="ejemplo@.emaol.com",
                    Nombre="Jesus Manuel Enades ",
                    NumeroDeTelefono="443159753",
                    FecaDeNacimento = DateTime.Parse("12-10-12"),
                    Id_organisacion = new OrganisacionDto
                    {
                        Id=1,
                        Nombre = "Ejemplo Dto",
                        Giro="Comercio",
                        ClaveInvitacion ="125235485",
                        Decripcion ="Sociedad anonima",
                        Id_tipoDeOraganisacion = new TipoDeOraganisacionDto
                        {
                            Id=1,
                            Descripcion = "Sociedad Privada "
                        }
    
                    },
                    Id_tipoDeCuenta= new TipoDeCuentaDto
                    {
                        Id=1,
                        RolUsario="Root"
                    }
                    
                }
            };
        }
        public static List<DocumentoDto> GetDocumentos()
        {
            return new List<DocumentoDto>
            {
                new DocumentoDto
                {
                    id=1,
                    URL=@"B:\Vicente\prollecos\investigación\InvestigacionDemo\Recursos\159753123456789.xml",
                    Id_Tipo = new Tipo_DocuemntoDto
                    {
                        id=1,
                        Nombre="Comprobate de tipo CFDI"
                    },
                    id_Usuario= DataDumi.Perfiles().FirstOrDefault()

                },
                new DocumentoDto
                {
                    id=1,
                    URL=@"B:\Vicente\prollecos\investigación\InvestigacionDemo\Recursos\156546192541.xml",
                    Id_Tipo = new Tipo_DocuemntoDto
                    {
                        id=1,
                        Nombre="Comprobate de tipo CFDI"
                    },
                    id_Usuario= DataDumi.Perfiles().FirstOrDefault()

                }
            };
        }

    }
}
