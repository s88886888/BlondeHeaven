using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class QAQ03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ShopKeeperId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ShopKeeperId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Commoditys",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sales",
                table: "Commoditys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CommodityViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateCommodity = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShopKeeperId = table.Column<int>(nullable: false),
                    ShopKeeperName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ShopKeepeid = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CommodityId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ShopKeeperName = table.Column<string>(nullable: true),
                    CommodityName = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    CreateCommodity = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommodityViewModel");

            migrationBuilder.DropTable(
                name: "OrderViewModel");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Commoditys");

            migrationBuilder.DropColumn(
                name: "Sales",
                table: "Commoditys");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShopKeeperId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ShopKeeperId",
                table: "Comments",
                column: "ShopKeeperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
