﻿// <auto-generated />
using System;
using ElectroniqueApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectroniqueApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240115103436_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectroniqueApi.Model.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Désignation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("ClientId")
                        .HasColumnType("tinyint");

                    b.Property<int>("ClientId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId1");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.LigneFacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("FactureId")
                        .HasColumnType("tinyint");

                    b.Property<int>("FactureId1")
                        .HasColumnType("int");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("ProduitId1")
                        .HasColumnType("int");

                    b.Property<int>("quantité")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FactureId1");

                    b.HasIndex("ProduitId1");

                    b.ToTable("LignesFactures");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("CategorieId")
                        .HasColumnType("tinyint");

                    b.Property<int>("CategorieId1")
                        .HasColumnType("int");

                    b.Property<string>("Désignation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LigneFactureId")
                        .HasColumnType("int");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.Facture", b =>
                {
                    b.HasOne("ElectroniqueApi.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.LigneFacture", b =>
                {
                    b.HasOne("ElectroniqueApi.Model.Facture", "Facture")
                        .WithMany()
                        .HasForeignKey("FactureId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElectroniqueApi.Model.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facture");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("ElectroniqueApi.Model.Produit", b =>
                {
                    b.HasOne("ElectroniqueApi.Model.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });
#pragma warning restore 612, 618
        }
    }
}
