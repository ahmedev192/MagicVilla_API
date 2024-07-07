using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaCreateDTO, VillaUpdateDTO>().ReverseMap();
        }
    }
}
