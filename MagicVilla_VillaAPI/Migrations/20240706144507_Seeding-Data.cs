using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautiful seaside villa with stunning ocean views.", "https://example.com/seasidevilla.jpg", "Seaside Villa", 8, 450.0, 3200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Fireplace, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy retreat nestled in the mountains.", "https://example.com/mountainretreat.jpg", "Mountain Retreat", 6, 300.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Pool, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A luxurious villa located in the heart of the city.", "https://example.com/urbanoasis.jpg", "Urban Oasis", 4, 500.0, 2500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "WiFi, AC, BBQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An oasis in the desert with all modern amenities.", "https://example.com/deserthaven.jpg", "Desert Haven", 7, 350.0, 2800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Pool, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stunning tropical villa with lush gardens.", "https://example.com/tropicalparadise.jpg", "Tropical Paradise", 5, 400.0, 3000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "WiFi, AC, Kayaks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene villa by the lake with picturesque views.", "https://example.com/lakesidelodge.jpg", "Lakeside Lodge", 6, 375.0, 2700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Fireplace, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peaceful hideaway surrounded by forest.", "https://example.com/foresthideaway.jpg", "Forest Hideaway", 4, 325.0, 2300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Pool, WiFi, AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming bungalow right on the beach.", "https://example.com/beachfrontbungalow.jpg", "Beachfront Bungalow", 7, 425.0, 3100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "WiFi, AC, Garden", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A quaint cottage in the countryside.", "https://example.com/countrysidecottage.jpg", "Countryside Cottage", 3, 275.0, 1800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Pool, WiFi, AC, Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A grand historic manor with timeless elegance.", "https://example.com/historicmanor.jpg", "Historic Manor", 10, 550.0, 4000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
