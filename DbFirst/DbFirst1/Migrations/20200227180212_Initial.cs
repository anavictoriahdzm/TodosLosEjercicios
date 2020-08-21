using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbFirst1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    IDAlumnos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    Apellidos = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Nombres = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FechaNac = table.Column<DateTime>(type: "date", nullable: false),
                    Direccion = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Alumnos__776B659D9788C7C4", x => x.IDAlumnos);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Descrip = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Imagen = table.Column<string>(unicode: false, nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(14, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
