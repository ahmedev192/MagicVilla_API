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
            CreateMap<Villa, VillaDTO>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberCreateDTO>()
                .ForMember(dest => dest.VillaNumber, opt => opt.MapFrom(src => src.VillaNo))
                .ReverseMap()
                .ForMember(dest => dest.VillaNo, opt => opt.MapFrom(src => src.VillaNumber));

            CreateMap<VillaNumber, VillaNumberUpdateDTO>()
                .ForMember(dest => dest.VillaNumber, opt => opt.MapFrom(src => src.VillaNo))
                .ReverseMap()
                .ForMember(dest => dest.VillaNo, opt => opt.MapFrom(src => src.VillaNumber));

            CreateMap<VillaNumber, VillaNumberDTO>()
                .ForMember(dest => dest.VillaNumber, opt => opt.MapFrom(src => src.VillaNo))
                .ReverseMap()
                .ForMember(dest => dest.VillaNo, opt => opt.MapFrom(src => src.VillaNumber));
        }
    }
}
