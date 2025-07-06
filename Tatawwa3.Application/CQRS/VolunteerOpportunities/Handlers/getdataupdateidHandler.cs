using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    public class getdataupdateidHandler : IRequestHandler<getdataupdateid, updateOportunuityDto>
    {
        protected IOpportunity opportunity;
        private readonly IMapper _mapper;
        public getdataupdateidHandler(IOpportunity opportunity, IMapper mapper)
        {
            this.opportunity = opportunity;
            _mapper = mapper;
        }
        public Task<updateOportunuityDto> Handle(getdataupdateid request, CancellationToken cancellationToken)
        {
            var entity = opportunity.GetByIdForUpdate(request.Id);

            if (entity == null)
                return Task.FromResult<updateOportunuityDto>(null);

            var dto = _mapper.Map<updateOportunuityDto>(entity);

            return Task.FromResult(dto);
        }
    }
}
