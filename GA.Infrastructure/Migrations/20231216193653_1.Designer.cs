﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GA.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231216193653_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GA.ApplicationCore.Domain.Avocat", b =>
                {
                    b.Property<int>("AvocatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvocatId"), 1L, 1);

                    b.Property<DateTime>("DateEmbauche")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpecialiteFK")
                        .HasColumnType("int");

                    b.HasKey("AvocatId");

                    b.HasIndex("SpecialiteFK");

                    b.ToTable("Avocats");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Client", b =>
                {
                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CIN");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Dossier", b =>
                {
                    b.Property<int>("AvocatFK")
                        .HasColumnType("int");

                    b.Property<string>("ClientFK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateDepot")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Cols")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Frais")
                        .HasColumnType("float");

                    b.HasKey("AvocatFK", "ClientFK", "DateDepot");

                    b.HasIndex("ClientFK");

                    b.ToTable("Dossiers");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomSpecialite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialites");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Avocat", b =>
                {
                    b.HasOne("GA.ApplicationCore.Domain.Specialite", "Specialite")
                        .WithMany("Avocats")
                        .HasForeignKey("SpecialiteFK");

                    b.Navigation("Specialite");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Dossier", b =>
                {
                    b.HasOne("GA.ApplicationCore.Domain.Avocat", "Avocat")
                        .WithMany("Dossiers")
                        .HasForeignKey("AvocatFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GA.ApplicationCore.Domain.Client", "Client")
                        .WithMany("Dossiers")
                        .HasForeignKey("ClientFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avocat");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Avocat", b =>
                {
                    b.Navigation("Dossiers");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Client", b =>
                {
                    b.Navigation("Dossiers");
                });

            modelBuilder.Entity("GA.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Navigation("Avocats");
                });
#pragma warning restore 612, 618
        }
    }
}
