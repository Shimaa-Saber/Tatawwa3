using AutoMapper;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.NotificationMap
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationDto>();
        }
    }

}
