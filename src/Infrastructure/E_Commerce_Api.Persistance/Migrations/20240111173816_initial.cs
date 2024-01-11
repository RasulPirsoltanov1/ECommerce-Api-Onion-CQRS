using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce_Api.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2517), false, "Kompyuterlər, Avtomobil & Filmlər" },
                    { 2, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2595), false, "uşaq üçün & Ev" },
                    { 3, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2616), false, "bəzək & Ev" },
                    { 4, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2627), false, "Ayyaqqabı" },
                    { 5, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2646), false, "oyunlar & musiqi" },
                    { 6, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2672), false, "bəzək, Səhiyyə & Səhiyyə" },
                    { 7, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2683), false, "Kitablar" },
                    { 8, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2707), false, "Avtomobil, uşaq üçün & İdman" },
                    { 9, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2731), false, "садинструмент, Ev & Kompyuterlər" },
                    { 10, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(2744), true, "Kompyuterlər" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(6565), false, "Electric", 0, 1 },
                    { 2, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(6567), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(6570), false, "Computers", 1, 1 },
                    { 4, new DateTime(2024, 1, 11, 17, 38, 16, 105, DateTimeKind.Utc).AddTicks(6572), false, "Women", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 11, 17, 38, 16, 109, DateTimeKind.Utc).AddTicks(9225), "Perferendis reprehenderit accusamus eligendi cumque.", false, "Accusamus." },
                    { 2, 3, new DateTime(2024, 1, 11, 17, 38, 16, 109, DateTimeKind.Utc).AddTicks(9320), "Hic cum libero dolores sed.", true, "Ipsa." },
                    { 3, 4, new DateTime(2024, 1, 11, 17, 38, 16, 112, DateTimeKind.Utc).AddTicks(3055), "Modi quia perferendis sint aut.", false, "Sunt." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreateDate", "Description", "Discount", "ImagePath", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 11, 21, 38, 16, 119, DateTimeKind.Local).AddTicks(2754), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 7.281794939205538m, null, false, 508.30m, "Fantastik Rezin Kompyuter" },
                    { 2, 3, new DateTime(2024, 1, 11, 21, 38, 16, 119, DateTimeKind.Local).AddTicks(2980), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2.900216720200555m, null, false, 215.44m, "Kobud Ağac Kəmər" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
