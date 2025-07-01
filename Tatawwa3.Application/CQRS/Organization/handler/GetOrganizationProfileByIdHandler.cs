using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.handler
{
    public class GetOrganizationProfileByIdHandler : IRequestHandler<GetOrganizationProfileByIdQuery, organisationdetails>
    {
        private readonly IOrganizationRepository _repository;
        public GetOrganizationProfileByIdHandler(IOrganizationRepository repository)
        {
            _repository = repository;
        }
        public  async Task<organisationdetails> Handle(GetOrganizationProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = _repository.GetByID(request.Id); 

            if (entity == null)
                throw new Exception("المنظمة غير موجودة");

            return MapperService.Map<organisationdetails>(entity);
        }
    }
}
