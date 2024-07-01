using MagicVilla_VillaAPI.Models.DTOs;

namespace MagicVilla_VillaAPI.Data
{
    public class Villas
    {
       public static List<VillaDTO> villas = new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name = "Pool View"},
                new VillaDTO{Id = 2, Name = "Beach View" }
            };
    }
}
