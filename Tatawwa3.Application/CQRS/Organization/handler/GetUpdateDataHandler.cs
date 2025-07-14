using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.handler
{
    public class GetUpdateDataHandler : IRequestHandler<GetUpdateDataQuery, UpdateOrganizationDto>
    {
        private readonly IOrganizationRepository _repository;
        private readonly IMapper _mapper;

        public GetUpdateDataHandler(IOrganizationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UpdateOrganizationDto> Handle(GetUpdateDataQuery request, CancellationToken cancellationToken)
        {
            var org =  _repository.GetByID(request.Id);
            if (org == null)
                throw new Exception("المنظمة غير موجودة");

            return _mapper.Map<UpdateOrganizationDto>(org);
        }
    }
}
