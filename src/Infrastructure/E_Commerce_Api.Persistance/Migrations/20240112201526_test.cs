using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5668), "Elektronika & gözəllik" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5839), "Ayyaqqabı & uşaq üçün" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5862), "Filmlər & musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5872), "oyunlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5891), "bəzək & Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5922), "Ev, bəzək & Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(5940), "musiqi & musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(6128), "Filmlər & Elektronika" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(6182), "uşaq üçün, Filmlər & Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 622, DateTimeKind.Utc).AddTicks(6208), "Filmlər & садинструмент" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 15, 26, 623, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 15, 26, 623, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 15, 26, 623, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 15, 26, 623, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 627, DateTimeKind.Utc).AddTicks(9234), "Velit fugit unde eum quidem.", "Officiis." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 627, DateTimeKind.Utc).AddTicks(9290), "Vero non et rerum at.", "Animi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 15, 26, 627, DateTimeKind.Utc).AddTicks(9343), "Qui maiores voluptatibus nemo quae.", "Corporis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 15, 26, 632, DateTimeKind.Local).AddTicks(6909), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8.146121774731867m, 402.42m, "Kobud Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 15, 26, 632, DateTimeKind.Local).AddTicks(7237), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9.013267865293903m, 32.00m, "İnanılmaz Pambıq Sviter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(8956), "Elektronika & Oyuncaqlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9052), "Ayyaqqabı, Avtomobil & Elektronika" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9064), "musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9087), "Ayyaqqabı, Ayyaqqabı & oyunlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9111), "Oyuncaqlar, садинструмент & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9123), "Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9133), "Ayyaqqabı" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9155), "turizm, oyunlar & oyunlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9179), "Avtomobil, oyunlar & bəzək" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9204), "садинструмент, uşaq üçün & bəzək" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(8953), "Quod cupiditate suscipit eaque facilis.", "Ad." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(9007), "Aliquid cumque molestiae voluptatem consectetur.", "Nesciunt." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(9103), "Voluptatibus omnis iusto odio nesciunt.", "Excepturi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Test", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 11, 23, 676, DateTimeKind.Local).AddTicks(1714), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5.199227960465908m, 203.72m, null, "Əlverişli Qranit Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Test", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 11, 23, 676, DateTimeKind.Local).AddTicks(1966), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9.526297259187136m, 66.06m, null, "İnanılmaz Rezin Avtomobil" });
        }
    }
}
