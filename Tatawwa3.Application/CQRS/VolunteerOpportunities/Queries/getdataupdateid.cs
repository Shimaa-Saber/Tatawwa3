using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class getdataupdateid:IRequest<updateOportunuityDto>
    {
        public string Id { get; set; }

        public getdataupdateid(string id)
        {
            Id = id;
        }
    }
}
