using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class AQA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Noodles");

            migrationBuilder.AlterColumn<int>(
                name: "ShopKeeperId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CommodityId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CommodityId",
                table: "Orders",
                column: "CommodityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Commoditys_CommodityId",
                table: "Orders",
                column: "CommodityId",
                principalTable: "Commoditys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Commoditys_CommodityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CommodityId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShopKeeperId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDateUTC = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Message = table.Column<string>(maxLength: 400, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noodles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageURL = table.Column<string>(nullable: true),
                    IsInStock = table.Column<bool>(nullable: false),
                    LongDescription = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noodles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
