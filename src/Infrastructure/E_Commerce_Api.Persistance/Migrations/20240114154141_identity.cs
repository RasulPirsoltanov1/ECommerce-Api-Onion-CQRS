using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9139), "Filmlər, bəzək & musiqi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9209), "Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9289), "gözəllik, Kompyuterlər & Kompyuterlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9314), "Səhiyyə, Avtomobil & Filmlər" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9336), "Geyim, Kompyuterlər & gözəllik" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9359), "Oyuncaqlar & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9369), "Oyuncaqlar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9391), "Səhiyyə, turizm & Geyim" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9416), "садинструмент, gözəllik & turizm" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 848, DateTimeKind.Utc).AddTicks(9437), "uşaq üçün & Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 36, 48, 849, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 36, 48, 849, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 36, 48, 849, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 12, 20, 36, 48, 849, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 853, DateTimeKind.Utc).AddTicks(7062), "Temporibus accusantium culpa dicta libero.", "Cum." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 853, DateTimeKind.Utc).AddTicks(7116), "Aperiam consequatur sint eveniet libero.", "At." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 36, 48, 853, DateTimeKind.Utc).AddTicks(7167), "Molestiae similique aperiam aut et.", "Qui." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 36, 48, 859, DateTimeKind.Local).AddTicks(6609), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7.525327856442751m, 603.73m, "Möhtəşəm Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 36, 48, 859, DateTimeKind.Local).AddTicks(6858), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1.02058807237729156m, 271.63m, "Ergonomik Rezin Kulon" });
        }
    }
}
