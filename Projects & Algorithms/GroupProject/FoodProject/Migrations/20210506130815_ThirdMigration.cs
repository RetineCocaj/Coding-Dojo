using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodProject.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Orders_OrderID",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_ShoppingCarts_ShoppingCartID",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Categories_CategoryID",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodItems",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_OrderID",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_ShoppingCartID",
                table: "FoodItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "ShoppingCartID",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "FoodItems",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItems_CategoryID",
                table: "FoodItems",
                newName: "IX_FoodItems_CategoryId");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartID",
                table: "AspNetUsers",
                newName: "ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ShoppingCartID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ShoppingCartId");

            migrationBuilder.AlterColumn<double>(
                name: "Sum",
                table: "ShoppingCarts",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCarts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShoppingCarts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ShoppingCarts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ShoppingCarts",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Orders",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Orders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "FoodItems",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<string>(
                name: "FoodItemId",
                table: "FoodItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartItemId",
                table: "FoodItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FoodItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "FoodItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodItems",
                table: "FoodItems",
                column: "FoodItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    isEnabled = table.Column<bool>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    Discriminator = table.Column<string>(maxLength: 128, nullable: false),
                    OrderId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CategoryId",
                table: "CartItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Categories_CategoryId",
                table: "FoodItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Categories_CategoryId",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodItems",
                table: "FoodItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FoodItemId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_UserID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "FoodItems",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItems_CategoryId",
                table: "FoodItems",
                newName: "IX_FoodItems_CategoryID");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "AspNetUsers",
                newName: "ShoppingCartID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ShoppingCartID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sum",
                table: "ShoppingCarts",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "ShoppingCarts",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "ShoppingCarts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Orders",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Orders",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "FoodItems",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "OrderID",
                table: "FoodItems",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "FoodItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartID",
                table: "FoodItems",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "FoodItems",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "FoodItems",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodItems",
                table: "FoodItems",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_OrderID",
                table: "FoodItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_ShoppingCartID",
                table: "FoodItems",
                column: "ShoppingCartID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartID",
                table: "AspNetUsers",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Orders_OrderID",
                table: "FoodItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_ShoppingCarts_ShoppingCartID",
                table: "FoodItems",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Categories_CategoryID",
                table: "FoodItems",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
