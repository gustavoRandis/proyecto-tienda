using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Repositorio.Migraciones
{
    public partial class InitialCatalogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: true),
                    Cant_producto = table.Column<string>(type: "varchar(45)", nullable: true),
                    Identificador = table.Column<string>(type: "varchar(45)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "date", nullable: true),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

    }
}