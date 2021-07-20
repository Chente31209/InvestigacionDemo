﻿// <auto-generated />
using System;
using Data.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvestigacionWebApiDemo.Migrations
{
    [DbContext(typeof(SecurityDbContext))]
    [Migration("20210716051827_Organisacion_Usuario")]
    partial class Organisacion_Usuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Data.Security.Contract.Entities.AcsesoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreDeUsario")
                        .HasColumnType("longtext");

                    b.Property<string>("Pasword")
                        .HasColumnType("longtext");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Acsesos");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.OrganisacionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaveInvitacion")
                        .HasColumnType("longtext");

                    b.Property<string>("Decripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Giro")
                        .HasColumnType("longtext");

                    b.Property<int?>("Id_tipoDeOraganisacionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Id_tipoDeOraganisacionId");

                    b.ToTable("Organisaciones");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.PermisosEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Decripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.TienePermiosoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Id_permisosId")
                        .HasColumnType("int");

                    b.Property<int?>("Id_tipoDeCuentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_permisosId");

                    b.HasIndex("Id_tipoDeCuentaId");

                    b.ToTable("TienePermioso");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.TipoDeCuentaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RolUsario")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TiposDeCuentas");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.TipoDeOraganisacionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TiposDeOraganisaciones");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.UsuarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("E_Mail")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FecaDeNacimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Id_organisacionId")
                        .HasColumnType("int");

                    b.Property<int?>("Id_tipoDeCuentaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDeTelefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Id_organisacionId");

                    b.HasIndex("Id_tipoDeCuentaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.AcsesoEntity", b =>
                {
                    b.HasOne("Data.Security.Contract.Entities.UsuarioEntity", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.OrganisacionEntity", b =>
                {
                    b.HasOne("Data.Security.Contract.Entities.TipoDeOraganisacionEntity", "Id_tipoDeOraganisacion")
                        .WithMany()
                        .HasForeignKey("Id_tipoDeOraganisacionId");

                    b.Navigation("Id_tipoDeOraganisacion");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.TienePermiosoEntity", b =>
                {
                    b.HasOne("Data.Security.Contract.Entities.PermisosEntity", "Id_permisos")
                        .WithMany()
                        .HasForeignKey("Id_permisosId");

                    b.HasOne("Data.Security.Contract.Entities.TipoDeCuentaEntity", "Id_tipoDeCuenta")
                        .WithMany()
                        .HasForeignKey("Id_tipoDeCuentaId");

                    b.Navigation("Id_permisos");

                    b.Navigation("Id_tipoDeCuenta");
                });

            modelBuilder.Entity("Data.Security.Contract.Entities.UsuarioEntity", b =>
                {
                    b.HasOne("Data.Security.Contract.Entities.OrganisacionEntity", "Id_organisacion")
                        .WithMany()
                        .HasForeignKey("Id_organisacionId");

                    b.HasOne("Data.Security.Contract.Entities.TipoDeCuentaEntity", "Id_tipoDeCuenta")
                        .WithMany()
                        .HasForeignKey("Id_tipoDeCuentaId");

                    b.Navigation("Id_organisacion");

                    b.Navigation("Id_tipoDeCuenta");
                });
#pragma warning restore 612, 618
        }
    }
}
