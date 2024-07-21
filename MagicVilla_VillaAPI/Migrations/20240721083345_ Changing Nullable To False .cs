using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangingNullableToFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6093), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6101), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6106), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6110), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6119), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6123), new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6125) });
        }
    }
}
