﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class GetOpportunitiemangmentQuery : IRequest<List<VolunteerOpportunityListDto>>
    {
        public string OrganizationId { get; set; }

        public GetOpportunitiemangmentQuery(string organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
