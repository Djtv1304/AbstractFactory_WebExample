using AbstractFactory.Models;
using AbstractFactory.Models.Factorys;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;

namespace AbstractFactory.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext
            (

                DbContextOptions<ApplicationDBContext> options

            ) : base(options) // Es como un super en herencia
        {



        }

        // Creo la tabla de esta manera en la DB
        public DbSet<MonedaGameboy> MonedaGameboy { get; set; }
        public DbSet<MonedaNintendoDS> MonedaNintendoDS { get; set; }
        public DbSet<BloqueInterroganteGameboy> BloqueInterroganteGameboy { get; set; }
        public DbSet<BloqueInterroganteNintendoDS> BloqueInterroganteNintendoDS { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Agregar datos a través de código con esta función
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonedaGameboy>().HasData(

                new MonedaGameboy
                {
                    IdMoneda = 1,
                    Color = "Dorado",
                    isStarCoin = true,
                    Valor = 30

                }

            );

            modelBuilder.Entity<MonedaNintendoDS>().HasData(

                new MonedaNintendoDS
                {

                    IdMoneda = 1,
                    Color = "Roja",
                    isStarCoin = false,
                    Valor = 60

                }

            );

            modelBuilder.Entity<BloqueInterroganteGameboy>().HasData(
                
                new BloqueInterroganteGameboy
                {

                    IdBloque = 1,
                    Color = "Dorado",
                    hasBricks = true,
                    hasUpgrade = true

                }
                
            );

            modelBuilder.Entity<BloqueInterroganteNintendoDS>().HasData(
                
                new BloqueInterroganteNintendoDS
                {

                    IdBloque = 1,
                    Color = "Rojo",
                    hasBricks = false,
                    hasUpgrade = false

                }
                
            );

            modelBuilder.Entity<Usuario>().HasData(

                new Usuario
                {
                    IdUsuario = 1,
                    Mail = "admin@admin.com",
                    Password = "admin"

                },

                new Usuario
                {

                    IdUsuario = 2,
                    Mail = "diego.toscano@udla.edu.ec",
                    Password = "f1e3l0i4pe"

                }

            );

        }

    }
}
