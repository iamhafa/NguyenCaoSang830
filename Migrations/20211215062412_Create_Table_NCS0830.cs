using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenCaoSang830.Migrations
{
    public partial class Create_Table_NCS0830 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NCS0830s",
                columns: table => new
                {
                    NCSId = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    NCSName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NCSGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCS0830s", x => x.NCSId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NCS0830s");
        }
    }
}
