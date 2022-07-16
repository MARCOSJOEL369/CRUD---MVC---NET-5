using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD___MVC___NET_5.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    kilometraje = table.Column<int>(type: "int", nullable: false),
                    AñoDeLanzamineto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
