using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerMangement;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Queries
{
    public class GetVolunteerProfileQuery : IRequest<VolunteerProfileDto>
    {
        public string UserId { get; set; }
        public GetVolunteerProfileQuery(string userId) => UserId = userId;
    }
}
