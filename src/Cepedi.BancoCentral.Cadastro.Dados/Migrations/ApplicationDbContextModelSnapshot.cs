﻿// <auto-generated />
using System;
using Cepedi.BancoCentral.Cadastro.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cepedi.BancoCentral.Cadastro.Dados.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.BancoEntity", b =>
                {
                    b.Property<int>("IdBanco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBanco"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeReal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBanco");

                    b.ToTable("Banco", (string)null);
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.PessoaEntity", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPessoa"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.PixEntity", b =>
                {
                    b.Property<int>("IdPix")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPix"));

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChavePix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTipoPix")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoPixEntityIdTipoPix")
                        .HasColumnType("int");

                    b.HasKey("IdPix");

                    b.HasIndex("TipoPixEntityIdTipoPix");

                    b.ToTable("Pix");
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.RegistroTransacaoBancoEntity", b =>
                {
                    b.Property<int>("IdRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistro"));

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdBanco")
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoRegistro")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("IdRegistro");

                    b.HasIndex("IdBanco");

                    b.HasIndex("IdPessoa");

                    b.HasIndex("IdTipoRegistro");

                    b.ToTable("RegistroTransacaoBanco", (string)null);
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.TipoPixEntity", b =>
                {
                    b.Property<int>("IdTipoPix")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPix"));

                    b.Property<string>("NomeTipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoPix");

                    b.ToTable("TipoPix");
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.TipoRegistroEntity", b =>
                {
                    b.Property<int>("IdTipoRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoRegistro"));

                    b.Property<string>("NomeTipo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdTipoRegistro");

                    b.ToTable("TipoRegistro", (string)null);
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.UsuarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<bool>("CelularValidado")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.PixEntity", b =>
                {
                    b.HasOne("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.TipoPixEntity", "TipoPixEntity")
                        .WithMany("Pixs")
                        .HasForeignKey("TipoPixEntityIdTipoPix");

                    b.Navigation("TipoPixEntity");
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.RegistroTransacaoBancoEntity", b =>
                {
                    b.HasOne("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.BancoEntity", "Banco")
                        .WithMany()
                        .HasForeignKey("IdBanco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.PessoaEntity", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.TipoRegistroEntity", "TipoRegistro")
                        .WithMany()
                        .HasForeignKey("IdTipoRegistro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");

                    b.Navigation("Pessoa");

                    b.Navigation("TipoRegistro");
                });

            modelBuilder.Entity("Cepedi.BancoCentral.Cadastro.Dominio.Entidades.TipoPixEntity", b =>
                {
                    b.Navigation("Pixs");
                });
#pragma warning restore 612, 618
        }
    }
}
