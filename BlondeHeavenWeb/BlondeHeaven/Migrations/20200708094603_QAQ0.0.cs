using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class QAQ00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Eamil",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eamil",
                table: "Orders");
        }
    }
}
