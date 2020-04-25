using Microsoft.EntityFrameworkCore.Migrations;

namespace Recotur2.Migrations
{
    public partial class IniciarCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidatos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanNombre = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    pass = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidatos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidatos");
        }
    }
}
