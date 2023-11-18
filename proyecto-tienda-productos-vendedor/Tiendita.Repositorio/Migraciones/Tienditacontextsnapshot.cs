using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Repositorio.Contexto;

namespace Tiendita.Repositorio.Migraciones
{
    [DbContext(typeof(TienditaContext))]
    partial class VideoClubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("tiendita.Entity.Entidades.Producto", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("idactor");

                b.Property<int>("CreatedBy")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime(6)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("tinyint(1)");

                b.Property<string>("NombreActor")
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnType("varchar")
                    .HasColumnName("nombreactor");

                b.Property<int>("UpdatedBy")
                    .HasColumnType("int");

                b.Property<DateTime>("UpdatedDate")
                    .HasColumnType("datetime(6)");

                b.HasKey("Id");

                b.ToTable("actores", (string)null);
            });
        }
    }
}
