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
        public string Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string Image { get; set; } 
        public DateTime StartDate { get; set; }
        public int RatingCount { get; set; }
        public string Location { get; set; }
    }
}
