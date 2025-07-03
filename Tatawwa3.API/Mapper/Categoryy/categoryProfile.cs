using AutoMapper;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.CategoryDto;

namespace Tatawwa3.API.Mapper.Categoryy
{
    public class categoryProfile:Profile
    {
        public categoryProfile()
        {
            CreateMap<Category, categorynames>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)); ;
        }
    }
}
