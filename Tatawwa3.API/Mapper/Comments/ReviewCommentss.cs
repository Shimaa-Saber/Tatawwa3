using AutoMapper;
using Tatawwa3.Application.Dtos.Review;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Comments
{
    public class ReviewCommentss:Profile
    {
        public ReviewCommentss() {
            CreateMap<Review, showReviewDto>()
        .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FullName));


        }
    }
}
