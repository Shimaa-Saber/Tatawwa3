using AutoMapper;
using Tatawwa3.Application.Dtos.InvitationDtos;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Helpers;

namespace Tatawwa3.API.Mapper.InvitationMap
{
    public class InvitationProfile:Profile
    {
        public InvitationProfile()
        {
            CreateMap<VolunteerInvitation, SentInvitationDto>()
                .ForMember(dest => dest.VolunteerFullName, opt => opt.Ignore()) // هنحطها يدويًا
                .ForMember(dest => dest.VolunteerEmail, opt => opt.Ignore())    // هنحطها يدويًا
                .ForMember(dest => dest.InvitationType, opt => opt.Ignore())    // هنحطها يدويًا
                .ForMember(dest => dest.InvitationName, opt => opt.Ignore())    // هنحطها يدويًا
                .ForMember(dest => dest.SentDate, opt => opt.MapFrom(src => src.SentAt.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => InvitationHelper.GetStatusLabel(src.Status)));
        }
    }
}
