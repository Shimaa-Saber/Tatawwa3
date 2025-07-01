using AutoMapper;
using Tatawwa3.Application.Dtos.AdminDashbord;

namespace Tatawwa3.API.Mapper.DashBrdAdmin
{
    public class DashboardProfile : Profile
    {
        public DashboardProfile()
        {
            CreateMap<(int Year, int Month, int Count), UserGrowthDto>()
                .ForMember(dest => dest.Month, opt => opt.MapFrom(src => $"{src.Year}-{src.Month:D2}"))
                .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count));
        }
    }
}
