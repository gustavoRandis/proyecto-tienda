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
                .HasColumnType("varchar(255)") // Tipo de dato de la columna en MySql.
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(a => a.Descripcion)
                .HasColumnName("Descripcion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar(45)") // Tipo de dato de la columna en MySql.
                .HasMaxLength(45);

            // Continúa configurando otras propiedades según la estructura de tu tabla 'producto' en la base de datos.
        }
    }
}
