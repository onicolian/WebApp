using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _iiii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ShortDesc = table.Column<string>(nullable: true),
                    LongDesc = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    IsFavorite = table.Column<bool>(nullable: false),
                    Avaliable = table.Column<bool>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderID = table.Column<Guid>(nullable: false),
                    JeweleryID = table.Column<Guid>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Jewelery_JeweleryID",
                        column: x => x.JeweleryID,
                        principalTable: "Jewelery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0cd43e48-c88b-442e-b4a3-13778636b7a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "166da51c-b07e-43d6-8e8f-38feb48380af", "AQAAAAEAACcQAAAAEJBTfUui4UYgt78gs80hUuHXfjR7DgdGWr7mXUejsEQ4gd8iYcr8whiOQ8QrBgDh1w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 19, 32, 35, 570, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 19, 32, 35, 570, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 19, 32, 35, 570, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_JeweleryID",
                table: "OrderDetail",
                column: "JeweleryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "2f8c0dfc-ec26-45d9-b600-e73cd02b3304");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c33171ad-d816-4ef3-bc7a-c60b1df84445", "AQAAAAEAACcQAAAAEO/+Ay+oTsTLBYTMZ9ZIUaKdhCoZK/reg3aUb3qvUAZJHj3GqCrFV8lXWr7A/C+tvg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 35, 40, 639, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 35, 40, 639, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 35, 40, 639, DateTimeKind.Utc).AddTicks(8177));
        }
    }
}
