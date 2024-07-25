using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4118), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4122), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 7, 25, 10, 51, 36, 509, DateTimeKind.Local).AddTicks(4134) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1164), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1214), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 7, 21, 11, 33, 44, 710, DateTimeKind.Local).AddTicks(1220) });
        }
    }
}
