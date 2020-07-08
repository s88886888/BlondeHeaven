using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class OPO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Eamil",
                table: "Orders",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Orders",
                newName: "Eamil");
        }
    }
}
