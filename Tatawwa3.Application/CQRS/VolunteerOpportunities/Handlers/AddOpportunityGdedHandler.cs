//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
//{
//    internal class AddOpportunityGdedHandler
//    {
//    }
//}
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using DomainTeam = Tatawwa3.Domain.Entities.Team;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    public class AddOpportunityGdedHandler : IRequestHandler<AddOpportunityGdedCommand, DetailsOpportunityDto>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IOrganizationRepository _organizationRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly ISkillReprosatry _skillRepo;
        private readonly IMapper _mapper;

        public AddOpportunityGdedHandler(
            IOpportunity opportunityRepo,
            ICategoryRepository categoryRepo,
            IOrganizationRepository organizationRepo,
            ITeamRepository teamRepo,
            ISkillReprosatry skillRepo,
            IMapper mapper)
        {
            _opportunityRepo = opportunityRepo;
            _categoryRepo = categoryRepo;
            _organizationRepo = organizationRepo;
            _teamRepo = teamRepo;
            _skillRepo = skillRepo;
            _mapper = mapper;
        }

        public async Task<DetailsOpportunityDto> Handle(AddOpportunityGdedCommand request, CancellationToken cancellationToken)
        {

            var dto = request.AddOpportunityDto;

            
            var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
            if (category == null)
                throw new Exception("الفئة غير موجودة");

            
            var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName);
            if (organization == null)
                throw new Exception("الجهة غير موجودة");

            
            DomainTeam? team = null;
            if (!string.IsNullOrWhiteSpace(dto.TeamName))
            {
                team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
                if (team == null)
                {
                    team = new DomainTeam
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = dto.TeamName
                    };
                    _teamRepo.Add(team);
                    await _teamRepo.SaveChangesAsync();
                }
            }

            
            var requiredSkills = new List<Skilless>();
            if (dto.RequiredSkillNames != null && dto.RequiredSkillNames.Any())
            {
                foreach (var skillName in dto.RequiredSkillNames.Where(s => !string.IsNullOrWhiteSpace(s)))
                {
                    var skill = await _skillRepo.FirstOrDefaultAsync(s => s.Name == skillName);
                    if (skill == null)
                    {
                        skill = new Skilless
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = skillName
                            // OpportunityID هيتظبط بعدين
                        };
                    }
                    requiredSkills.Add(skill);
                }
            }

           
            string? savedImagePath = null;
            if (dto.Image != null && dto.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Image.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.Image.CopyToAsync(stream, cancellationToken);

                //savedImagePath = Path.Combine("uploads", fileName);
                savedImagePath = fileName;

            }


            var opportunity = _mapper.Map<VolunteerOpportunity>(dto);
            opportunity.Id = Guid.NewGuid().ToString();
            opportunity.CategoryID = category.Id;
            opportunity.OrganizationID = organization.Id;
            opportunity.TeamId = team?.Id;
            opportunity.Image = savedImagePath;
            opportunity.Status = OpportunityStatus.Published;

            
            foreach (var skill in requiredSkills)
            {
                skill.OpportunityID = opportunity.Id;
            }
            opportunity.RequiredSkills = requiredSkills;

            try
            {
                _opportunityRepo.Add(opportunity);
                foreach (var skill in requiredSkills)
                {
                    _skillRepo.Add(skill); 
                }
                await _opportunityRepo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("خطأ أثناء الحفظ: " + (ex.InnerException?.Message ?? ex.Message));
            }

            return _mapper.Map<DetailsOpportunityDto>(opportunity);


            //    var dto = request.AddOpportunityDto;

            //    // التأكد من وجود الفئة
            //    var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
            //    if (category == null)
            //        throw new Exception("الفئة غير موجودة");

            //    // التأكد من وجود الجهة
            //    var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName);
            //    if (organization == null)
            //        throw new Exception("الجهة غير موجودة");

            //    // التيم اختياري
            //    DomainTeam? team = null;
            //    if (!string.IsNullOrWhiteSpace(dto.TeamName))
            //    {
            //        team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
            //        if (team == null)
            //        {
            //            team = new DomainTeam
            //            {
            //                Id = Guid.NewGuid().ToString(),
            //                Name = dto.TeamName
            //            };
            //            _teamRepo.Add(team);
            //            await _teamRepo.SaveChangesAsync();
            //        }
            //    }

            //    // المهارات المطلوبة
            //    var requiredSkills = new List<Skilless>();
            //    if (dto.RequiredSkillNames != null && dto.RequiredSkillNames.Any())
            //    {
            //        foreach (var skillName in dto.RequiredSkillNames.Where(s => !string.IsNullOrWhiteSpace(s)))
            //        {
            //            var skill = await _skillRepo.FirstOrDefaultAsync(s => s.Name == skillName);
            //            if (skill == null)
            //            {
            //                skill = new Skilless
            //                {
            //                    Id = Guid.NewGuid().ToString(),
            //                    Name = skillName,
            //                    OpportunityID = "" // هيتضبط بعد إضافة الفرصة
            //                };
            //                _skillRepo.Add(skill);
            //                await _skillRepo.SaveChangesAsync();
            //            }
            //            requiredSkills.Add(skill);
            //        }
            //    }

            //    // حفظ الصورة إن وجدت
            //    string? savedImagePath = null;
            //    if (dto.Image != null && dto.Image.Length > 0)
            //    {
            //        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            //        Directory.CreateDirectory(uploadsFolder);
            //        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Image.FileName);
            //        var fullPath = Path.Combine(uploadsFolder, fileName);

            //        using var stream = new FileStream(fullPath, FileMode.Create);
            //        await dto.Image.CopyToAsync(stream, cancellationToken);

            //        savedImagePath = Path.Combine("uploads", fileName);
            //    }

            //    // إنشاء الفرصة
            //    var opportunity = _mapper.Map<VolunteerOpportunity>(dto);
            //    opportunity.Id = Guid.NewGuid().ToString();
            //    opportunity.CategoryID = category.Id;
            //    opportunity.OrganizationID = organization.Id;
            //    opportunity.TeamId = team?.Id;
            //    opportunity.Image = savedImagePath;
            //    opportunity.Status = OpportunityStatus.Published;

            //    // ربط المهارات بالفرصة
            //    foreach (var skill in requiredSkills)
            //    {
            //        skill.OpportunityID = opportunity.Id;
            //    }
            //    opportunity.RequiredSkills = requiredSkills;

            //    try
            //    {
            //        _opportunityRepo.Add(opportunity);
            //        await _opportunityRepo.SaveChangesAsync();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception("خطأ أثناء الحفظ: " + (ex.InnerException?.Message ?? ex.Message));
            //    }

            //    return _mapper.Map<DetailsOpportunityDto>(opportunity);
            //}


        }
    }
}

