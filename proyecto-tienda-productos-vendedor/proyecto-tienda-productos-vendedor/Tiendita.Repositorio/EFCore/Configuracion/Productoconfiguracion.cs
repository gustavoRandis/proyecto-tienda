using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
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
                .HasColumnName("Id_producto") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("Id_producto");
            
            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(a => a.Descripcion)
                .HasColumnName("Descripcion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Tipo de dato de la columna en MySql.
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(a => a.Cant_producto)
                .HasColumnName("Cant_producto") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("INT") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.Identificador)
                .HasColumnName("Identificador") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("INT") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.FechaCreacion)
                .HasColumnName("FechaCreacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("DATETIME(0)") // Tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.FechaActualizacion)
                .HasColumnName("FechaActualizacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("DATETIME(0)") // Tipo de dato de la columna en MySql.
                .IsRequired();
            builder.Property(a => a.IsDeleted)
            .HasColumnName("IsDeleted")
            .HasColumnType("bool")
            .IsRequired();
        }
    }
}
