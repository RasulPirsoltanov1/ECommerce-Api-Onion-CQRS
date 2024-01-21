using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpireTime",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1213), "Filmlər & садинструмент" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1302), "Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1325), "gözəllik & Geyim" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1336), "Kompyuterlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1348), "İdman" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1367), "Səhiyyə & bəzək" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1377), "Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1402), "Kompyuterlər, Kompyuterlər & садинструмент" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(1429), "садинструмент, Kompyuterlər & Oyuncaqlar" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 23, 7, 24, 224, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 227, DateTimeKind.Utc).AddTicks(7792), "Sit sed minima nemo dolores.", "Placeat." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 227, DateTimeKind.Utc).AddTicks(8123), "Asperiores necessitatibus asperiores velit sunt.", "Quam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 7, 24, 227, DateTimeKind.Utc).AddTicks(8227), "Velit molestiae nihil nam nesciunt.", "Ut." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 7, 24, 233, DateTimeKind.Local).AddTicks(8778), "The Football Is Good For Training And Recreational Purposes", 3.006701951477419m, 444.70m, "İntellektual Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 7, 24, 233, DateTimeKind.Local).AddTicks(9001), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7.991840060888077m, 825.84m, "Möhtəşəm Qranit Kəmər" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpireTime",
                table: "AspNetRoles",
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
                column: "CreateDate",
                value: new DateTime(2024, 1, 21, 22, 18, 45, 645, DateTimeKind.Utc).AddTicks(9624));

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
    }
}
