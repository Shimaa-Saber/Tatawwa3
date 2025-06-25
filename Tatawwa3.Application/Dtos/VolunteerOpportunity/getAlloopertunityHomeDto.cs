using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public class OpportunityHomeDto
    {
        public string Id { get; set; } // لزر طلب الفرصة
        public string Title { get; set; } // عنوان الفرصة
        public string Description { get; set; } // وصف مختصر
        public string Image { get; set; } // صورة الفرصة
        public DateTime StartDate { get; set; } // تاريخ الفرصة
        public int RatingCount { get; set; } // عدد التقييمات
    }
}
