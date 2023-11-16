using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;
using MySql.EntityFrameworkCore.Extensions;

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
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idproducto");// Indica que es una columna de identidad en MySQL.

            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
