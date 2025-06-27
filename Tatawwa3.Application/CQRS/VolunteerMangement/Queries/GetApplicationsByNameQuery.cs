using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Queries
{
    public class GetApplicationsByNameQuery : IRequest<List<ApplicationDto>>
    {
        public string Name { get; set; }

        public GetApplicationsByNameQuery(string name)
        {
            Name = name;
        }
    }

    public class GetApplicationsByNameHandler : IRequestHandler<GetApplicationsByNameQuery, List<ApplicationDto>>
    {
        private readonly IApplicationService _applicationService;

        public GetApplicationsByNameHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<List<ApplicationDto>> Handle(GetApplicationsByNameQuery request, CancellationToken cancellationToken)
        {
            return await _applicationService.GetApplicationsByNameAsync(request.Name);
        }
    }
}
