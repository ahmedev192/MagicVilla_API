﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.DTOs
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNumber { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }

    }
}
