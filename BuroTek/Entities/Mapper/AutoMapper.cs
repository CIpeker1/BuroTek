using AutoMapper;
using BuroTek.Entities.Dtos;
using BuroTek.Entities.Entities.Dtos;
using BuroTek.Entities.Models;

namespace BuroTek.Entities.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Notlar, NotlarResponseModel>().ReverseMap();

            CreateMap<User, UserResponseModel>().ReverseMap();

            CreateMap<Arsiv, ArsivResponseModel>().ReverseMap();
        }
    }
}
