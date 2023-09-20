﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Programare_medic.Data;

#nullable disable

namespace Programare_medic.Migrations
{
    [DbContext(typeof(Programare_medicContext))]
    partial class Programare_medicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Programare_medic.Models.Medic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Medic");
                });

            modelBuilder.Entity("Programare_medic.Models.Pacient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nume")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Prenume")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Pacient");
                });

            modelBuilder.Entity("Programare_medic.Models.Programare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataProgramare")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicID")
                        .HasColumnType("int");

                    b.Property<int?>("PacientID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiciuID")
                        .HasColumnType("int");

                    b.Property<int?>("SpitalID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MedicID");

                    b.HasIndex("PacientID");

                    b.HasIndex("ServiciuID");

                    b.HasIndex("SpitalID");

                    b.ToTable("Programare");
                });

            modelBuilder.Entity("Programare_medic.Models.Sectie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireSectie")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Sectie");
                });

            modelBuilder.Entity("Programare_medic.Models.Serviciu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Cost_consultatie")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("Data_Programare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire_Serviciu")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("MedicID")
                        .HasColumnType("int");

                    b.Property<int?>("SpitalID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MedicID");

                    b.HasIndex("SpitalID");

                    b.ToTable("Serviciu");
                });

            modelBuilder.Entity("Programare_medic.Models.ServiciuSectie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("SectieID")
                        .HasColumnType("int");

                    b.Property<int>("ServiciuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SectieID");

                    b.HasIndex("ServiciuID");

                    b.ToTable("ServiciuSectie");
                });

            modelBuilder.Entity("Programare_medic.Models.Spital", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireSpital")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Spital");
                });

            modelBuilder.Entity("Programare_medic.Models.Programare", b =>
                {
                    b.HasOne("Programare_medic.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicID");

                    b.HasOne("Programare_medic.Models.Pacient", "Pacient")
                        .WithMany("Programari")
                        .HasForeignKey("PacientID");

                    b.HasOne("Programare_medic.Models.Serviciu", "Serviciu")
                        .WithMany()
                        .HasForeignKey("ServiciuID");

                    b.HasOne("Programare_medic.Models.Spital", "Spital")
                        .WithMany()
                        .HasForeignKey("SpitalID");

                    b.Navigation("Medic");

                    b.Navigation("Pacient");

                    b.Navigation("Serviciu");

                    b.Navigation("Spital");
                });

            modelBuilder.Entity("Programare_medic.Models.Serviciu", b =>
                {
                    b.HasOne("Programare_medic.Models.Medic", "Medic")
                        .WithMany("Servicii")
                        .HasForeignKey("MedicID");

                    b.HasOne("Programare_medic.Models.Spital", "Spital")
                        .WithMany("Servicii")
                        .HasForeignKey("SpitalID");

                    b.Navigation("Medic");

                    b.Navigation("Spital");
                });

            modelBuilder.Entity("Programare_medic.Models.ServiciuSectie", b =>
                {
                    b.HasOne("Programare_medic.Models.Sectie", "Sectie")
                        .WithMany("ServiciuSectii")
                        .HasForeignKey("SectieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Programare_medic.Models.Serviciu", "Serviciu")
                        .WithMany("ServiciuSectii")
                        .HasForeignKey("ServiciuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sectie");

                    b.Navigation("Serviciu");
                });

            modelBuilder.Entity("Programare_medic.Models.Medic", b =>
                {
                    b.Navigation("Servicii");
                });

            modelBuilder.Entity("Programare_medic.Models.Pacient", b =>
                {
                    b.Navigation("Programari");
                });

            modelBuilder.Entity("Programare_medic.Models.Sectie", b =>
                {
                    b.Navigation("ServiciuSectii");
                });

            modelBuilder.Entity("Programare_medic.Models.Serviciu", b =>
                {
                    b.Navigation("ServiciuSectii");
                });

            modelBuilder.Entity("Programare_medic.Models.Spital", b =>
                {
                    b.Navigation("Servicii");
                });
#pragma warning restore 612, 618
        }
    }
}
