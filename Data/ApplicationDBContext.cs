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
        public DbSet<Miembro> Miembro { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Visita> Visita { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Agregar datos a través de código con esta función
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Miembro>().HasData(

                new Miembro
                {
                    idMiembro = 1,
                    nombreMiembro = "Oscar",
                    idMembresia = 1, // Asigno la membresía Oro a Oscar
                    apellidoMiembro = "Almeida",
                    emailMiembro = "oscar.almedia@udla.edu.ec",
                    fechaInscripcion = DateTime.Parse("2024-03-15")
                },
                new Miembro
                {
                    idMiembro = 2,
                    nombreMiembro = "Diego",
                    idMembresia = 2, // Asigno la membresía Plata a Diego
                    apellidoMiembro = "Toscano",
                    emailMiembro = "diego.toscano@udla.edu.ec",
                    fechaInscripcion = DateTime.Parse("2024-04-15")
                }

            );

        }

    }
}
