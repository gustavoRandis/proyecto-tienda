using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reglasdenegocio.Entidades;

namespace Tiendita.Repositorio.EFCore.Configuracion
{
    public class ProductoConfiguracion : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("producto");

            builder.HasKey(a => a.Id); // Clave primaria.

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("Id") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int"); // Tipo de dato de la columna en MySql.

            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar(45)") // Tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(a => a.Descripcion)
                .HasColumnName("Descripcion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar(45)") // Tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(a => a.Cant_producto)
                .HasColumnName("Cant_producto") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.Identificador)
                .HasColumnName("Identificador") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.FechaCreacion)
                .HasColumnName("FechaCreacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("date") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.FechaActualizacion)
                .HasColumnName("FechaActualizacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("date") // Tipo de dato de la columna en MySql.
                .IsRequired();
        }
    }
}
