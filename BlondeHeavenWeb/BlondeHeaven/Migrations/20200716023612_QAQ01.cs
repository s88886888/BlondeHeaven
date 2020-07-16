using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class QAQ01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "ShopKeeperId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "ShopKeeperId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
