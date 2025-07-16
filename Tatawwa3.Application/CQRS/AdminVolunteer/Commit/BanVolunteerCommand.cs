using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.AdminVolunteer.Commit
{
    public class BanVolunteerCommand : IRequest<bool>
    {
        public string VolunteerId { get; set; }
    }
}
