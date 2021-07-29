using Microsoft.EntityFrameworkCore.Migrations;

namespace BEZendframework.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(100)", nullable: false),
                    fecha = table.Column<string>(type: "varchar(100)", nullable: false),
                    sueldo = table.Column<string>(type: "varchar(16)", nullable: false),
                    idsector = table.Column<string>(type: "varchar(16)", nullable: false),
                    idzona = table.Column<string>(type: "varchar(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBPersona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBPersona");
        }
    }
}
