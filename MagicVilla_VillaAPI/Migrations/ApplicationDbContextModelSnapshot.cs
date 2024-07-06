﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Pool, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7905),
                            Details = "A beautiful seaside villa with stunning ocean views.",
                            ImageURL = "https://example.com/seasidevilla.jpg",
                            Name = "Seaside Villa",
                            Occupancy = 8,
                            Rate = 450.0,
                            Sqft = 3200,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7948)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Fireplace, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7952),
                            Details = "A cozy retreat nestled in the mountains.",
                            ImageURL = "https://example.com/mountainretreat.jpg",
                            Name = "Mountain Retreat",
                            Occupancy = 6,
                            Rate = 300.0,
                            Sqft = 2000,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7954)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Pool, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7957),
                            Details = "A luxurious villa located in the heart of the city.",
                            ImageURL = "https://example.com/urbanoasis.jpg",
                            Name = "Urban Oasis",
                            Occupancy = 4,
                            Rate = 500.0,
                            Sqft = 2500,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7958)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "WiFi, AC, BBQ",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7960),
                            Details = "An oasis in the desert with all modern amenities.",
                            ImageURL = "https://example.com/deserthaven.jpg",
                            Name = "Desert Haven",
                            Occupancy = 7,
                            Rate = 350.0,
                            Sqft = 2800,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7962)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Pool, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7964),
                            Details = "A stunning tropical villa with lush gardens.",
                            ImageURL = "https://example.com/tropicalparadise.jpg",
                            Name = "Tropical Paradise",
                            Occupancy = 5,
                            Rate = 400.0,
                            Sqft = 3000,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7965)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "WiFi, AC, Kayaks",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7968),
                            Details = "A serene villa by the lake with picturesque views.",
                            ImageURL = "https://example.com/lakesidelodge.jpg",
                            Name = "Lakeside Lodge",
                            Occupancy = 6,
                            Rate = 375.0,
                            Sqft = 2700,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(7969)
                        },
                        new
                        {
                            Id = 7,
                            Amenity = "Fireplace, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8013),
                            Details = "A peaceful hideaway surrounded by forest.",
                            ImageURL = "https://example.com/foresthideaway.jpg",
                            Name = "Forest Hideaway",
                            Occupancy = 4,
                            Rate = 325.0,
                            Sqft = 2300,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8015)
                        },
                        new
                        {
                            Id = 8,
                            Amenity = "Pool, WiFi, AC",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8018),
                            Details = "A charming bungalow right on the beach.",
                            ImageURL = "https://example.com/beachfrontbungalow.jpg",
                            Name = "Beachfront Bungalow",
                            Occupancy = 7,
                            Rate = 425.0,
                            Sqft = 3100,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8019)
                        },
                        new
                        {
                            Id = 9,
                            Amenity = "WiFi, AC, Garden",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8021),
                            Details = "A quaint cottage in the countryside.",
                            ImageURL = "https://example.com/countrysidecottage.jpg",
                            Name = "Countryside Cottage",
                            Occupancy = 3,
                            Rate = 275.0,
                            Sqft = 1800,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8023)
                        },
                        new
                        {
                            Id = 10,
                            Amenity = "Pool, WiFi, AC, Library",
                            CreatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8025),
                            Details = "A grand historic manor with timeless elegance.",
                            ImageURL = "https://example.com/historicmanor.jpg",
                            Name = "Historic Manor",
                            Occupancy = 10,
                            Rate = 550.0,
                            Sqft = 4000,
                            UpdatedDate = new DateTime(2024, 7, 6, 17, 47, 51, 158, DateTimeKind.Local).AddTicks(8026)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
