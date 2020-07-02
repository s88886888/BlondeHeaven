using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class AA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Commoditys_CommoditysId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CommoditysId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CommoditysId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommodityId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Uesrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CommoditysId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CommoditysId",
                table: "Orders",
                column: "CommoditysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Commoditys_CommoditysId",
                table: "Orders",
                column: "CommoditysId",
                principalTable: "Commoditys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Uesrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
