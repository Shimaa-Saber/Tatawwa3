using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.ViewModels;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class GetAllVolunteerOpportunitiesQuery : IRequest<List<VolunteerOpportunityVM>>
    {
       //لو حبيت بعدين اعمل فلترة 
        //public string? City { get; set; }
        //public DateTime? FromDate { get; set; }
    }
}
