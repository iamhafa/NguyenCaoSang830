using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenCaoSang830.Migrations
{
    public partial class Create_Table_UniversityNCS830 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityNCS830",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNCS830", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityNCS830");
        }
    }
}
