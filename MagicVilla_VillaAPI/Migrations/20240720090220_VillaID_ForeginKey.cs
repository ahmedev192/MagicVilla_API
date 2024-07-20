using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class VillaID_ForeginKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaID = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaID",
                        column: x => x.VillaID,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6040), "A beautiful seaside villa with stunning ocean views.", "https://example.com/seasidevilla.jpg", "Seaside Villa", 8, 450.0, 3200, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6083) },
                    { 2, "Fireplace, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6088), "A cozy retreat nestled in the mountains.", "https://example.com/mountainretreat.jpg", "Mountain Retreat", 6, 300.0, 2000, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6090) },
                    { 3, "Pool, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6093), "A luxurious villa located in the heart of the city.", "https://example.com/urbanoasis.jpg", "Urban Oasis", 4, 500.0, 2500, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6094) },
                    { 4, "WiFi, AC, BBQ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6097), "An oasis in the desert with all modern amenities.", "https://example.com/deserthaven.jpg", "Desert Haven", 7, 350.0, 2800, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6099) },
                    { 5, "Pool, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6101), "A stunning tropical villa with lush gardens.", "https://example.com/tropicalparadise.jpg", "Tropical Paradise", 5, 400.0, 3000, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6103) },
                    { 6, "WiFi, AC, Kayaks", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6106), "A serene villa by the lake with picturesque views.", "https://example.com/lakesidelodge.jpg", "Lakeside Lodge", 6, 375.0, 2700, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6107) },
                    { 7, "Fireplace, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6110), "A peaceful hideaway surrounded by forest.", "https://example.com/foresthideaway.jpg", "Forest Hideaway", 4, 325.0, 2300, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6112) },
                    { 8, "Pool, WiFi, AC", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6115), "A charming bungalow right on the beach.", "https://example.com/beachfrontbungalow.jpg", "Beachfront Bungalow", 7, 425.0, 3100, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6116) },
                    { 9, "WiFi, AC, Garden", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6119), "A quaint cottage in the countryside.", "https://example.com/countrysidecottage.jpg", "Countryside Cottage", 3, 275.0, 1800, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6121) },
                    { 10, "Pool, WiFi, AC, Library", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6123), "A grand historic manor with timeless elegance.", "https://example.com/historicmanor.jpg", "Historic Manor", 10, 550.0, 4000, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6125) }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaID" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6241), " Very Good Villa ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6244), 1 },
                    { 3, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6248), " Very Good Villa ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6249), 2 },
                    { 4, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6252), " Very Good Villa ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6253), 3 },
                    { 5, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6256), " Very Good Villa ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6257), 4 },
                    { 6, new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6259), " Very Good Villa ", new DateTime(2024, 7, 20, 12, 2, 20, 375, DateTimeKind.Local).AddTicks(6261), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
