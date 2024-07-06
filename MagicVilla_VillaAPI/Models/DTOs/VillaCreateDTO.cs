using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTOs
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Amenity { get; set; }

    }
}
