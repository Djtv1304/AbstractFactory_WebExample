﻿// <auto-generated />
using AbstractFactory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbstractFactory.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240111030900_PruebaTablas")]
    partial class PruebaTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AbstractFactory.Models.BloqueInterroganteGameboy", b =>
                {
                    b.Property<int>("IdBloque")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBloque"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasBricks")
                        .HasColumnType("bit");

                    b.Property<bool>("hasUpgrade")
                        .HasColumnType("bit");

                    b.HasKey("IdBloque");

                    b.ToTable("BloqueInterroganteGameboy");

                    b.HasData(
                        new
                        {
                            IdBloque = 1,
                            Color = "Dorado",
                            hasBricks = true,
                            hasUpgrade = true
                        });
                });

            modelBuilder.Entity("AbstractFactory.Models.BloqueInterroganteNintendoDS", b =>
                {
                    b.Property<int>("IdBloque")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBloque"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasBricks")
                        .HasColumnType("bit");

                    b.Property<bool>("hasUpgrade")
                        .HasColumnType("bit");

                    b.HasKey("IdBloque");

                    b.ToTable("BloqueInterroganteNintendoDS");

                    b.HasData(
                        new
                        {
                            IdBloque = 1,
                            Color = "Rojo",
                            hasBricks = false,
                            hasUpgrade = false
                        });
                });

            modelBuilder.Entity("AbstractFactory.Models.MonedaGameboy", b =>
                {
                    b.Property<int>("IdMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMoneda"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<bool>("isStarCoin")
                        .HasColumnType("bit");

                    b.HasKey("IdMoneda");

                    b.ToTable("MonedaGameboy");

                    b.HasData(
                        new
                        {
                            IdMoneda = 1,
                            Color = "Dorado",
                            Valor = 30,
                            isStarCoin = true
                        });
                });

            modelBuilder.Entity("AbstractFactory.Models.MonedaNintendoDS", b =>
                {
                    b.Property<int>("IdMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMoneda"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<bool>("isStarCoin")
                        .HasColumnType("bit");

                    b.HasKey("IdMoneda");

                    b.ToTable("MonedaNintendoDS");

                    b.HasData(
                        new
                        {
                            IdMoneda = 1,
                            Color = "Roja",
                            Valor = 60,
                            isStarCoin = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
