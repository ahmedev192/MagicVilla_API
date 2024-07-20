using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
            new Villa
            {
                Id = 1,
                Name = "Seaside Villa",
                Details = "A beautiful seaside villa with stunning ocean views.",
                Rate = 450.00,
                Sqft = 3200,
                Occupancy = 8,
                ImageURL = "https://example.com/seasidevilla.jpg",
                Amenity = "Pool, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,

            },
            new Villa
            {
                Id = 2,
                Name = "Mountain Retreat",
                Details = "A cozy retreat nestled in the mountains.",
                Rate = 300.00,
                Sqft = 2000,
                Occupancy = 6,
                ImageURL = "https://example.com/mountainretreat.jpg",
                Amenity = "Fireplace, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 3,
                Name = "Urban Oasis",
                Details = "A luxurious villa located in the heart of the city.",
                Rate = 500.00,
                Sqft = 2500,
                Occupancy = 4,
                ImageURL = "https://example.com/urbanoasis.jpg",
                Amenity = "Pool, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 4,
                Name = "Desert Haven",
                Details = "An oasis in the desert with all modern amenities.",
                Rate = 350.00,
                Sqft = 2800,
                Occupancy = 7,
                ImageURL = "https://example.com/deserthaven.jpg",
                Amenity = "WiFi, AC, BBQ"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 5,
                Name = "Tropical Paradise",
                Details = "A stunning tropical villa with lush gardens.",
                Rate = 400.00,
                Sqft = 3000,
                Occupancy = 5,
                ImageURL = "https://example.com/tropicalparadise.jpg",
                Amenity = "Pool, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 6,
                Name = "Lakeside Lodge",
                Details = "A serene villa by the lake with picturesque views.",
                Rate = 375.00,
                Sqft = 2700,
                Occupancy = 6,
                ImageURL = "https://example.com/lakesidelodge.jpg",
                Amenity = "WiFi, AC, Kayaks"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 7,
                Name = "Forest Hideaway",
                Details = "A peaceful hideaway surrounded by forest.",
                Rate = 325.00,
                Sqft = 2300,
                Occupancy = 4,
                ImageURL = "https://example.com/foresthideaway.jpg",
                Amenity = "Fireplace, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 8,
                Name = "Beachfront Bungalow",
                Details = "A charming bungalow right on the beach.",
                Rate = 425.00,
                Sqft = 3100,
                Occupancy = 7,
                ImageURL = "https://example.com/beachfrontbungalow.jpg",
                Amenity = "Pool, WiFi, AC"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 9,
                Name = "Countryside Cottage",
                Details = "A quaint cottage in the countryside.",
                Rate = 275.00,
                Sqft = 1800,
                Occupancy = 3,
                ImageURL = "https://example.com/countrysidecottage.jpg",
                Amenity = "WiFi, AC, Garden"
                ,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 10,
                Name = "Historic Manor",
                Details = "A grand historic manor with timeless elegance.",
                Rate = 550.00,
                Sqft = 4000,
                Occupancy = 10,
                ImageURL = "https://example.com/historicmanor.jpg",
                Amenity = "Pool, WiFi, AC, Library",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });


            modelBuilder.Entity<VillaNumber>().HasData(
            new VillaNumber
            {
                VillaNo = 2,
                VillaID = 1 , 
                SpecialDetails = " Very Good Villa ",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 3,
                VillaID = 2 ,
                SpecialDetails = " Very Good Villa ",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 4,
                VillaID = 3 ,
                SpecialDetails = " Very Good Villa ",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 5,
                VillaID = 4 ,
                SpecialDetails = " Very Good Villa ",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 6,
                VillaID = 5 ,
                SpecialDetails = " Very Good Villa ",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            } );

        }
    }
}
