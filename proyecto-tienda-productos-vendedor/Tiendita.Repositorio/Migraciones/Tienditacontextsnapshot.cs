using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using reglasdenegocio.Entidades;
using Tiendita.Repositorio.Contexto;

namespace Tiendita.Repositorio.Migraciones
{
    [DbContext(typeof(TienditaContext))]
    partial class Tienditacontextsnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.34")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity<Producto>(b =>
            {
                b.ToTable("producto");

                b.Property<int>("Id")
                    .HasColumnType("int")
                    .HasColumnName("Id")
                    .IsRequired();

                b.Property<string>("Nombre")
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Nombre")
                    .IsRequired();

                b.Property<string>("Descripcion")
                    .HasColumnType("varchar(45)")
                    .HasColumnName("Descripcion");

                b.Property<string>("Cant_producto")
                    .HasColumnType("varchar(45)")
                    .HasColumnName("Cant_producto");

                b.Property<string>("Identificador")
                    .HasColumnType("varchar(45)")
                    .HasColumnName("Identificador");

                b.Property<DateTime>("FechaCreacion")
                    .HasColumnType("date")
                    .HasColumnName("FechaCreacion");

                b.Property<DateTime>("FechaActualizacion")
                    .HasColumnType("date")
                    .HasColumnName("FechaActualizacion");

                b.HasKey("Id");
            });
        }
    }
}
