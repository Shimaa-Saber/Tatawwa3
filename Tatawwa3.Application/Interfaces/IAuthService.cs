using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AuthDtos;

namespace Tatawwa3.Application.Interfaces
{
    public interface IAuthService
    {
        Task RegisterVolunteerAsync(RegisterVolunteerDto dto);
        Task RegisterOrganizationAsync(RegisterOrganizationDto dto);

    }
}
