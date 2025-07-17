using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Review
{
    public class showReviewDto
    {
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
       public string Id { get; set; }
        public string OpportunityId { get; set; }
        public string UserId { get; set; }
        public string? UserProfilePicture { get; set; }  // جديدة

    }
}
