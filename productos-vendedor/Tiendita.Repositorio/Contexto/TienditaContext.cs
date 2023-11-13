﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;
using Tiendita.Entity.Entidades;

namespace Tiendita.Repositorio.Contexto
{
    // Este código define un contexto de base de datos llamado VideoClubContext
    // que hereda de DbContext en Entity Framework Core.
 public class TienditaContext : DbContext
        {
            // El constructor recibe opciones de configuración de DbContext.
            public TienditaContext(DbContextOptions<TienditaContext> options) : base(options) { }

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseMySQL("Server = localhost; Port = 3306; Database = trailerfix; User = root; Password = MySql");

            //    //"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LaPaulitaDB;Integrated Security=SSPI;"
            //}

            // DbSet define propiedades para acceder a las tablas en la base de datos.
            public DbSet<Chat> chats { get; set; } 
            public DbSet<Cliente> Clientes { get; set; } 
            public DbSet<Pago> pagos { get; set; } 
            public DbSet<Pedido> pedidos { get; set; } 
            public DbSet<Producto> productos { get; set; } 
            public DbSet<Publicaciones> publicaciones { get; set; } 
            public DbSet<Stock> Stock { get; set; } 
            public DbSet<Vendedor> Vendedor { get; set; } 


        // Este método se llama al configurar el modelo de base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Aplica configuraciones de entidades desde el ensamblado actual.
                modelBuilder.ApplyConfigurationsFromAssembly(
                    Assembly.GetExecutingAssembly());
            }
        }
    }

