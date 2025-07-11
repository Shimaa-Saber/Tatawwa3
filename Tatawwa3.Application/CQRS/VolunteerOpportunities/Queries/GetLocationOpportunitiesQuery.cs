﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class GetLocationOpportunitiesQuery:IRequest<List<searchDto>>
    {
        public string Location { get; set; }

        public GetLocationOpportunitiesQuery(string location)
        {
            Location = location;
        }
    }
}
