﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Queries
{
    public class GetActiveVolunteersCountQuery : IRequest<int>
    {
    }
}
