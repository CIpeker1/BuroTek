using AutoMapper;
using BuroTek.Dtos;
using BuroTek.Model;
using BuroTek.Models;

namespace BuroTek.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<Notlar, NotlarResponseModel>().ReverseMap();
            
            CreateMap<User, UserResponseModel>().ReverseMap();

            CreateMap<Arsiv, ArsivResponseModel>().ReverseMap(); 
        }
    }
}
