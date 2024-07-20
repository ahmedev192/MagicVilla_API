﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTOs
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNumber { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }

    }
}
