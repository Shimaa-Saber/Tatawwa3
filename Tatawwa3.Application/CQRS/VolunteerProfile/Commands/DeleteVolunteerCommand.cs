using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.VolunteerProfile.Commands
{
    public class DeleteVolunteerCommand : IRequest<string>
    {
        public string _UserId { get; set; }

        public DeleteVolunteerCommand(string UserId)
        {
            _UserId = UserId;
        }
    }
}
