using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class cnfg_appuser_tbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9542), "bəzək, Oyuncaqlar & İdman" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9624), "bəzək" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9644), "Elektronika, uşaq üçün & musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9661), "uşaq üçün, oyunlar & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9678), "Geyim, musiqi & uşaq üçün" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9696), "Ev, Kitablar & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9703), "Kitablar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9715), "İdman & oyunlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9730), "oyunlar, musiqi & Kitablar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9746), "gözəllik & Filmlər" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 22, 18, 45, 646, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 22, 18, 45, 646, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 22, 18, 45, 646, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 22, 18, 45, 646, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 649, DateTimeKind.Utc).AddTicks(9166), "Ut quod ab facilis qui.", "Pariatur." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 649, DateTimeKind.Utc).AddTicks(9204), "Et quisquam voluptatem consectetur accusamus.", "Eos." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 18, 45, 649, DateTimeKind.Utc).AddTicks(9238), "Fuga esse enim pariatur numquam.", "Soluta." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 22, 2, 18, 45, 654, DateTimeKind.Local).AddTicks(1812), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6.322220683647526m, 82.67m, "İntellektual Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 22, 2, 18, 45, 654, DateTimeKind.Local).AddTicks(2003), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3.451186075840498m, 417.46m, "Balaca Beton Sviter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7472), "musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7643), "Filmlər & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7679), "uşaq üçün & Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7714), "Səhiyyə & Kitablar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7759), "Ev, Filmlər & Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7796), "Kompyuterlər & musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7814), "uşaq üçün" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7845), "turizm & Geyim" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7863), "Kitablar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 550, DateTimeKind.Utc).AddTicks(7906), "Səhiyyə, musiqi & oyunlar" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 15, 41, 40, 551, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 15, 41, 40, 551, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 15, 41, 40, 551, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 15, 41, 40, 551, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 556, DateTimeKind.Utc).AddTicks(7300), "Eum et qui quos repellat.", "Molestiae." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 556, DateTimeKind.Utc).AddTicks(7392), "Suscipit quam sunt magni aut.", "Modi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 41, 40, 556, DateTimeKind.Utc).AddTicks(7476), "Alias qui deserunt nam ullam.", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 14, 19, 41, 40, 564, DateTimeKind.Local).AddTicks(3957), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3.961443534084514m, 721.97m, "Əlverişli Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 14, 19, 41, 40, 564, DateTimeKind.Local).AddTicks(4308), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1.1248708293649774m, 145.20m, "Möhtəşəm Plastik Stul" });
        }
    }
}
