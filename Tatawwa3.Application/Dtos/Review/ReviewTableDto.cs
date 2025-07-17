using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Review
{
    public class ReviewTableDto
    {
        public string ReviewId { get; set; }               // ✅ الجديد
        public string OpportunityId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public string OpportunityName { get; set; }
    }
}
