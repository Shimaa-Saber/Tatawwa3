////using System;
////using System.Collections.Generic;
////using System.Diagnostics;
////using System.Linq;
////using System.Reflection.Metadata;
////using System.Text;
////using System.Threading.Tasks;
////using AutoMapper;
////using MediatR;
////using Tatawwa3.Application.CQRS.Team.Commands;
////using Tatawwa3.Domain.Enums;
////using Tatawwa3.Domain.Interfaces;
////using Tatawwa3.Infrastructure.Repositorirs;

////namespace Tatawwa3.Application.CQRS.Team.Handlers
////{
////    public class CreateTeamCommandHandler:IRequestHandler<CreateTeamCommand, Unit>
////    {

////        private readonly IGeneric<Tatawwa3.Domain.Entities.Team> _teamRepository;
////        private readonly IMapper _mapper;

////        public CreateTeamCommandHandler(IGeneric<Tatawwa3.Domain.Entities.Team> teamRepository, IMapper mapper)
////        {
////            _teamRepository = teamRepository;
////            _mapper = mapper;
////        }

////        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
////        {
////            var team = _mapper.Map<Tatawwa3.Domain.Entities.Team>(request.Dto);

////            team.Status = TeamStatus.Pending;
////            team.CreationDate = DateTime.UtcNow;

////            team.Id = Guid.NewGuid().ToString();
////            _teamRepository.Add(team);
////            await _teamRepository.SaveChangesAsync();

////            return Unit.Value;
////        }


////    }
////}
//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using AutoMapper;
//using MediatR;
//using Tatawwa3.Application.CQRS.Team.Commands;
//using Tatawwa3.Domain.Entities;
//using Tatawwa3.Domain.Enums;
//using Tatawwa3.Domain.Interfaces;

//namespace Tatawwa3.Application.CQRS.Team.Handlers
//{
//    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Unit>
//    {
//        private readonly IGeneric<Tatawwa3.Domain.Entities.Team> _teamRepository;
//        private readonly IGeneric<Category> _categoryRepository;
//        private readonly IGeneric<VolunteerOpportunity> _opportunityRepository;
//        private readonly IMapper _mapper;

//        public CreateTeamCommandHandler(
//     IGeneric<Tatawwa3.Domain.Entities.Team> teamRepository,
//     IGeneric<Category> categoryRepository,
//     IGeneric<VolunteerOpportunity> opportunityRepository,
//     IMapper mapper)
//        {
//            _teamRepository = teamRepository;
//            _categoryRepository = categoryRepository;
//            _opportunityRepository = opportunityRepository;
//            _mapper = mapper;
//        }

//        public IGeneric<Tatawwa3.Domain.Entities.Team> TeamRepository => _teamRepository;

//        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
//        {
//            var dto = request.Dto;
//            var team = _mapper.Map<Tatawwa3.Domain.Entities.Team>(dto);

//            // اضبطي الحالة وتاريخ الإنشاء والـ ID
//            team.Status = TeamStatus.Pending;
//            team.CreationDate = DateTime.UtcNow;
//            team.Id = Guid.NewGuid().ToString();

//            // ✅ ربط الـ Category عن طريق الاسم
//            if (!string.IsNullOrWhiteSpace(dto.CategoryName))
//            {
//                var category = await _categoryRepository
//                    .FindAsync(c => c.Name == dto.CategoryName);

//                if (category != null)
//                    team.CategoryId = category.Id;
//            }

//            // ✅ ربط الفرصة إن وجدت
//            if (!string.IsNullOrWhiteSpace(dto.OpportunityTitle))
//            {
//                var opportunity = await _opportunityRepository
//                    .FindAsync(o => o.Title == dto.OpportunityTitle);

//                if (opportunity != null)
//                    team.OpportunityId = opportunity.Id;
//            }

//            TeamRepository.Add(team);
//            await TeamRepository.SaveChangesAsync();

//            return Unit.Value;
//        }
//    }
//}


using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Team.Handlers
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Unit>
    {
        private readonly IGeneric<Tatawwa3.Domain.Entities.Team> _teamRepository;
        private readonly IGeneric<Category> _categoryRepository;
        private readonly IGeneric<VolunteerOpportunity> _opportunityRepository;
        private readonly IMapper _mapper;

        public CreateTeamCommandHandler(
            IGeneric<Tatawwa3.Domain.Entities.Team> teamRepository,
            IGeneric<Category> categoryRepository,
            IGeneric<VolunteerOpportunity> opportunityRepository,
            IMapper mapper)
        {
            _teamRepository = teamRepository;
            _categoryRepository = categoryRepository;
            _opportunityRepository = opportunityRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var dto = request.Dto;
            var team = _mapper.Map<Tatawwa3.Domain.Entities.Team>(dto);

            team.Status = TeamStatus.Pending;
            team.CreationDate = DateTime.UtcNow;
            team.Id = Guid.NewGuid().ToString();

            // البحث عن الـ Category بالاسم
            if (!string.IsNullOrWhiteSpace(dto.CategoryName))
            {
                var category = await _categoryRepository
                    .FirstOrDefaultAsync(c => c.Name == dto.CategoryName);

                if (category != null)
                    team.CategoryId = category.Id;
            }

            // البحث عن الفرصة بعنوانها
            if (!string.IsNullOrWhiteSpace(dto.OpportunityTitle))
            {
                var opportunity = await _opportunityRepository
                    .FirstOrDefaultAsync(o => o.Title == dto.OpportunityTitle);

                if (opportunity != null)
                    team.OpportunityId = opportunity.Id;
            }

            _teamRepository.Add(team);
            await _teamRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}