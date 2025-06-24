using AutoMapper;
using Tatawwa3.Application.Dtos.ApplicationDtos;

using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.ApplicationMap
{
    public class ApplicationMappingProfile:Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<addApplicationDto, Tatawwa3.Domain.Entities.Application>()
                
                .ForMember(dest => dest.AttachmentPath, opt => opt.Ignore())
                .ForMember(dest => dest.ApplicationDate, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore());
        }
    }
}
