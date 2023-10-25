﻿// <auto-generated />
using EnsaioApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnsaioApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230928015911_mg-3")]
    partial class mg3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnsaioApp.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("ClienteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("EnsaioApp.Models.Ensaio", b =>
                {
                    b.Property<int>("EnsaioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnsaioId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("EnsaioId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.EnsaioDeCurtoCircuito", b =>
                {
                    b.Property<int>("EnsaioDeCurtoCircuitoId")
                        .HasColumnType("int");

                    b.Property<string>("CorrenteDeCurtoCircuitoA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("PotenciaDeCurtoCircuito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemperaturaAmbienteC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoDeCurtoCircuitoV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnsaioDeCurtoCircuitoId");

                    b.ToTable("EnsaioDeCurtoCircuito");
                });

            modelBuilder.Entity("EnsaioApp.Models.EnsaioEmVazio", b =>
                {
                    b.Property<int>("EnsaioEmVazioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnsaioEmVazioId"));

                    b.Property<string>("CorrenteDeExcitacaoA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrenteDeExcitacaoPercentual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("PerdasEmVazioW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoPreEnsaioV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnsaioEmVazioId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("EnsaioEmVazio");
                });

            modelBuilder.Entity("EnsaioApp.Models.RelacaoDeTransformacao", b =>
                {
                    b.Property<int>("RelacaoDeTransformacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RelacaoDeTransformacaoId"));

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("Fase1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fase2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fase3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentualErro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RelacaoDeTransformacaoId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("RelacaoDeTransformacao");
                });

            modelBuilder.Entity("EnsaioApp.Models.ResistenciaIsolamento", b =>
                {
                    b.Property<int>("ResistenciaIsolamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResistenciaIsolamentoId"));

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("LeituraAtBt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeituraAtMassa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeituraBtMassa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoDoMegometro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResistenciaIsolamentoId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("ResistenciaIsolamento");
                });

            modelBuilder.Entity("EnsaioApp.Models.ResistenciaOhmicaEnrolamentos", b =>
                {
                    b.Property<int>("ResistenciaOhmicaEnrolamentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResistenciaOhmicaEnrolamentosId"));

                    b.Property<string>("EnrolTi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnrolTs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("H1H3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H1h2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H2H3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemperaturaAmbiente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("X1x2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("X1x3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("X2x3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResistenciaOhmicaEnrolamentosId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("ResistenciaOhmicaEnrolamentos");
                });

            modelBuilder.Entity("EnsaioApp.Models.Rotina", b =>
                {
                    b.Property<int>("RotinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RotinaId"));

                    b.Property<string>("AtLigadaEmKv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BtLigadaEmKv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrentAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrentBt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataFabricacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Derivacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frequencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ligacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MassaKg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Potencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoBt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RotinaId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("Rotina");
                });

            modelBuilder.Entity("EnsaioApp.Models.TensaoAplicada", b =>
                {
                    b.Property<int>("TensaoAplicadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TensaoAplicadaId"));

                    b.Property<string>("AtBtMassaKv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BtAMassaKv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("FrequenciaHz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoDeEnsaio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TensaoAplicadaId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("TensaoAplicada");
                });

            modelBuilder.Entity("EnsaioApp.Models.TensaoInduzida", b =>
                {
                    b.Property<int>("TensaoInduzidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TensaoInduzidaId"));

                    b.Property<int>("EnsaioId")
                        .HasColumnType("int");

                    b.Property<string>("FrequenciaHz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetodoDeEnsaio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoDeEnsaio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TensaoInduzidaV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TensaoInduzidaId");

                    b.HasIndex("EnsaioId")
                        .IsUnique();

                    b.ToTable("TensaoInduzida");
                });

            modelBuilder.Entity("EnsaioApp.Models.Ensaio", b =>
                {
                    b.HasOne("EnsaioApp.Models.Cliente", "Cliente")
                        .WithMany("Ensaios")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EnsaioApp.Models.EnsaioDeCurtoCircuito", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("EnsaioDeCurtoCircuito")
                        .HasForeignKey("EnsaioApp.Models.EnsaioDeCurtoCircuito", "EnsaioDeCurtoCircuitoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.EnsaioEmVazio", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("EnsaioEmVazio")
                        .HasForeignKey("EnsaioApp.Models.EnsaioEmVazio", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.RelacaoDeTransformacao", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("RelacaoDeTransformacao")
                        .HasForeignKey("EnsaioApp.Models.RelacaoDeTransformacao", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.ResistenciaIsolamento", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("ResistenciaIsolamento")
                        .HasForeignKey("EnsaioApp.Models.ResistenciaIsolamento", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.ResistenciaOhmicaEnrolamentos", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("ResistenciaOhmicaEnrolamentos")
                        .HasForeignKey("EnsaioApp.Models.ResistenciaOhmicaEnrolamentos", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.Rotina", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("Rotina")
                        .HasForeignKey("EnsaioApp.Models.Rotina", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.TensaoAplicada", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("TensaoAplicada")
                        .HasForeignKey("EnsaioApp.Models.TensaoAplicada", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.TensaoInduzida", b =>
                {
                    b.HasOne("EnsaioApp.Models.Ensaio", "Ensaio")
                        .WithOne("TensaoInduzida")
                        .HasForeignKey("EnsaioApp.Models.TensaoInduzida", "EnsaioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ensaio");
                });

            modelBuilder.Entity("EnsaioApp.Models.Cliente", b =>
                {
                    b.Navigation("Ensaios");
                });

            modelBuilder.Entity("EnsaioApp.Models.Ensaio", b =>
                {
                    b.Navigation("EnsaioDeCurtoCircuito")
                        .IsRequired();

                    b.Navigation("EnsaioEmVazio")
                        .IsRequired();

                    b.Navigation("RelacaoDeTransformacao")
                        .IsRequired();

                    b.Navigation("ResistenciaIsolamento")
                        .IsRequired();

                    b.Navigation("ResistenciaOhmicaEnrolamentos")
                        .IsRequired();

                    b.Navigation("Rotina")
                        .IsRequired();

                    b.Navigation("TensaoAplicada")
                        .IsRequired();

                    b.Navigation("TensaoInduzida")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}