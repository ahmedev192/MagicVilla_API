using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            //Old Way : 
            //CreateMap<Villa, VillaCreateDTO>();
            //CreateMap<VillaCreateDTO, Villa>();
            //CreateMap<Villa, VillaUpdateDTO>();
            //CreateMap<VillaUpdateDTO, Villa>();
            //CreateMap<VillaCreateDTO, VillaUpdateDTO>();
            //CreateMap<VillaUpdateDTO, VillaCreateDTO>();

            //Simpler Way :
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaCreateDTO, VillaUpdateDTO>().ReverseMap();
        }
    }
}
