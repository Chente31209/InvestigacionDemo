using System;
using Data.Security.Contract.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Security
{
    public class SecurityDbContext : DbContext
    {
        public  SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options) { }

        public DbSet<AcsesoEntity> Acsesos { get; set; }
        public DbSet<OrganisacionEntity> Organisaciones { get; set; }
        public DbSet<PermisosEntity> Permisos { get; set; }
        public DbSet<TipoDeCuentaEntity> TiposDeCuentas { get; set; }
        public DbSet<TipoDeOraganisacionEntity> TiposDeOraganisaciones{ get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<TienePermiosoEntity> TienePermioso { get; set; }
    }
}
