using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
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
                    JeweleryId = table.Column<Guid>(nullable: true),
                    ShopCartID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItem_Jewelery_JeweleryId",
                        column: x => x.JeweleryId,
                        principalTable: "Jewelery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_JeweleryId",
                table: "ShopCartItem",
                column: "JeweleryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItem");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "87b3bc25-77fe-4787-91f2-409e9ee3cf0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eab4e054-7e57-41c3-8ff7-55fedeb387df", "AQAAAAEAACcQAAAAEK5j2PeVLCAMdMkLq2M+I/CJ/ect10W7N9vLyl5SbthJXm0+Lkl8TGkYyJrvfqKDRA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 21, 54, 123, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 21, 54, 122, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 11, 16, 21, 54, 123, DateTimeKind.Utc).AddTicks(1500));
        }
    }
}
