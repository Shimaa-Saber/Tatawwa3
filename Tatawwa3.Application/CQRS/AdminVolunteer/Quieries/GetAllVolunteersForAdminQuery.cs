using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.AdminVolunteer;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.CQRS.AdminVolunteer.Quieries
{
    public class GetAllVolunteersForAdminQuery : IRequest<List<AdminVolunteerManagementDTO>>
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public VolunteerStatus? Status { get; set; }
        public double? Hours { get; set; }
    }
}
