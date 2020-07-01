using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlondeHeaven.Migrations
{
    public partial class InitialCreateA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_ShopKeepers_ShopKeeperId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_ShopKeepers_ShopKeeperId",
                table: "Commodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShopKeepers_ShopKeeperId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Ranking_ShopKeepers_ShopKeeperId",
                table: "Ranking");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopKeepers_UserShop_UserShopId",
                table: "ShopKeepers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserShop",
                table: "UserShop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranking",
                table: "Ranking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commodity",
                table: "Commodity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "UserShop",
                newName: "UserShops");

            migrationBuilder.RenameTable(
                name: "Ranking",
                newName: "Rankings");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Commodity",
                newName: "Commoditys");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Ranking_ShopKeeperId",
                table: "Rankings",
                newName: "IX_Rankings_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ShopKeeperId",
                table: "Orders",
                newName: "IX_Orders_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Commodity_ShopKeeperId",
                table: "Commoditys",
                newName: "IX_Commoditys_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ShopKeeperId",
                table: "Comments",
                newName: "IX_Comments_ShopKeeperId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Commoditys",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserShops",
                table: "UserShops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rankings",
                table: "Rankings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commoditys",
                table: "Commoditys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Uesrs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsRemo = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Sex = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(maxLength: 40, nullable: false),
                    Photo = table.Column<string>(maxLength: 5000, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PassWrod = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uesrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Waiters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsRemo = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Sex = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Commoditys_UserId",
                table: "Commoditys",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Uesrs_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Uesrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commoditys_ShopKeepers_ShopKeeperId",
                table: "Commoditys",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commoditys_Uesrs_UserId",
                table: "Commoditys",
                column: "UserId",
                principalTable: "Uesrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Uesrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rankings_ShopKeepers_ShopKeeperId",
                table: "Rankings",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopKeepers_UserShops_UserShopId",
                table: "ShopKeepers",
                column: "UserShopId",
                principalTable: "UserShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShopKeepers_ShopKeeperId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Uesrs_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Commoditys_ShopKeepers_ShopKeeperId",
                table: "Commoditys");

            migrationBuilder.DropForeignKey(
                name: "FK_Commoditys_Uesrs_UserId",
                table: "Commoditys");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShopKeepers_ShopKeeperId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Uesrs_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rankings_ShopKeepers_ShopKeeperId",
                table: "Rankings");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopKeepers_UserShops_UserShopId",
                table: "ShopKeepers");

            migrationBuilder.DropTable(
                name: "Uesrs");

            migrationBuilder.DropTable(
                name: "Waiters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserShops",
                table: "UserShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rankings",
                table: "Rankings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commoditys",
                table: "Commoditys");

            migrationBuilder.DropIndex(
                name: "IX_Commoditys_UserId",
                table: "Commoditys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Commoditys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "UserShops",
                newName: "UserShop");

            migrationBuilder.RenameTable(
                name: "Rankings",
                newName: "Ranking");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Commoditys",
                newName: "Commodity");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Rankings_ShopKeeperId",
                table: "Ranking",
                newName: "IX_Ranking_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShopKeeperId",
                table: "Order",
                newName: "IX_Order_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Commoditys_ShopKeeperId",
                table: "Commodity",
                newName: "IX_Commodity_ShopKeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ShopKeeperId",
                table: "Comment",
                newName: "IX_Comment_ShopKeeperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserShop",
                table: "UserShop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranking",
                table: "Ranking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commodity",
                table: "Commodity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_ShopKeepers_ShopKeeperId",
                table: "Comment",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_ShopKeepers_ShopKeeperId",
                table: "Commodity",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShopKeepers_ShopKeeperId",
                table: "Order",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ranking_ShopKeepers_ShopKeeperId",
                table: "Ranking",
                column: "ShopKeeperId",
                principalTable: "ShopKeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopKeepers_UserShop_UserShopId",
                table: "ShopKeepers",
                column: "UserShopId",
                principalTable: "UserShop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
