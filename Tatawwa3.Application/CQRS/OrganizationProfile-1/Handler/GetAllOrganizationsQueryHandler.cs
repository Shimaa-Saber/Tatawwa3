using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Handler
{
    public class GetAllOrganizationsQueryHandler : IRequestHandler<GetAllOrganizationsQuery, List<OrganizationbasedFilterationDTO>>
    {
        private readonly Tatawwa3DbContext _context;
        private readonly IMapper _mapper;

        public GetAllOrganizationsQueryHandler(Tatawwa3DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<OrganizationbasedFilterationDTO>> Handle(GetAllOrganizationsQuery request, CancellationToken cancellationToken)
        {
            return await _context.OrganizationProfiles
              .Where(o => !o.IsDeleted)

                .ProjectTo<OrganizationbasedFilterationDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}