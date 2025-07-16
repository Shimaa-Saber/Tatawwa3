using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using DomainTeam = Tatawwa3.Domain.Entities.Team;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class AddOpportunityHandler : IRequestHandler<AddOpportunityCommand, DetailsOpportunityDto>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IOrganizationRepository _organizationRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly ISkillReprosatry _skillRepo;

        public AddOpportunityHandler(
            IOpportunity opportunityRepo,
            ICategoryRepository categoryRepo,
            IOrganizationRepository organizationRepo,
            ITeamRepository teamRepo,
            ISkillReprosatry skillRepo)
        {
            _opportunityRepo = opportunityRepo;
            _categoryRepo = categoryRepo;
            _organizationRepo = organizationRepo;
            _teamRepo = teamRepo;
            _skillRepo = skillRepo;
        }


        public async Task<DetailsOpportunityDto> Handle(AddOpportunityCommand request, CancellationToken cancellationToken)
        {
            var dto = request.AddOpportunityDto;

            // 1. جلب الكاتيجوري - لو مش موجودة ارمي استثناء
            var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
            if (category == null)
                throw new Exception("الفئة غير موجودة، يجب اختيار فئة مسجلة مسبقاً.");

            // 2. جلب المنظمة - لو مش موجودة ارمي استثناء
            var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName);
            if (organization == null)
                throw new Exception("الجهة غير موجودة، يجب اختيار جهة مسجلة.");

            // 3. جلب التيم لو اتكتب، غير كده سيبه null
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

            // 4. جلب المهارات المطلوبة
            var requiredSkills = new List<Skilless>();
            if (dto.RequiredSkillNames != null && dto.RequiredSkillNames.Any())
            {
                foreach (var skillName in dto.RequiredSkillNames.Where(n => !string.IsNullOrWhiteSpace(n)))
                {
                    var skill = await _skillRepo.FirstOrDefaultAsync(s => s.Name == skillName);
                    if (skill == null)
                    {
                        skill = new Skilless
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = skillName
                        };
                        _skillRepo.Add(skill);
                        await _skillRepo.SaveChangesAsync();
                    }
                    requiredSkills.Add(skill);
                }
            }

            // 5. حفظ الصورة (اختياري)
            string? savedImagePath = null;
            if (dto.Image != null && dto.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Image.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.Image.CopyToAsync(stream, cancellationToken);

                savedImagePath = Path.Combine("uploads", fileName);
            }

            // 6. إنشاء الفرصة التطوعية
            var opportunity = dto.Map<VolunteerOpportunity>();
            opportunity.Id = Guid.NewGuid().ToString();
            opportunity.CategoryID = category.Id;
            opportunity.OrganizationID = organization.Id;
            opportunity.TeamId = team?.Id;
            opportunity.Image = savedImagePath;
            opportunity.Status = OpportunityStatus.Published;
            opportunity.RequiredSkills = requiredSkills;

            // 7. حفظ الفرصة
            _opportunityRepo.Add(opportunity);
            await _opportunityRepo.SaveChangesAsync();

            return opportunity.Map<DetailsOpportunityDto>();
        }






        //public async Task<DetailsOpportunityDto> Handle(AddOpportunityCommand request, CancellationToken cancellationToken)
        //{
        //    var dto = request.AddOpportunityDto;

        //    // جلب أو إنشاء الكاتيجوري
        //    var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
        //    if (category == null && !string.IsNullOrWhiteSpace(dto.CategoryName))
        //    {
        //        category = new Category
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = dto.CategoryName,
        //            Description = "وصف افتراضي للفئة",
        //            Icon = "default.png"
        //        };
        //        _categoryRepo.Add(category);
        //        await _categoryRepo.SaveChangesAsync();
        //    }

        //    // جلب المنظمة
        //    var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName)
        //        ?? throw new Exception("الجهه اللي اتكتبت مش موجودة");

        //    // جلب أو إنشاء الفريق (لو الاسم موجود)
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
        //                    Name = skillName
        //                };
        //                _skillRepo.Add(skill);
        //                await _skillRepo.SaveChangesAsync();
        //            }
        //            requiredSkills.Add(skill);
        //        }
        //    }

        //    // حفظ الصورة لو فيه صورة
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

        //    // إنشاء الفرصة التطوعية
        //    var opportunity = dto.Map<VolunteerOpportunity>();
        //    opportunity.Id = Guid.NewGuid().ToString();
        //    opportunity.CategoryID = category?.Id;
        //    opportunity.OrganizationID = organization.Id;
        //    opportunity.TeamId = team?.Id;
        //    opportunity.Status = OpportunityStatus.Published;
        //    opportunity.Image = savedImagePath;

        //    opportunity.Organization = null;
        //    opportunity.Category = null;
        //    opportunity.Team = null;
        //    opportunity.RequiredSkills = requiredSkills;

        //    try
        //    {
        //        _opportunityRepo.Add(opportunity);
        //        await _opportunityRepo.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        var inner = ex.InnerException;
        //        while (inner?.InnerException != null)
        //            inner = inner.InnerException;

        //        throw new Exception("خطأ أثناء الحفظ:\n" + inner?.Message ?? ex.Message);
        //    }

        //    return opportunity.Map<DetailsOpportunityDto>();
        //}













        //public async Task<DetailsOpportunityDto> Handle(AddOpportunityCommand request, CancellationToken cancellationToken)
        //{
        //    var dto = request.AddOpportunityDto;

        //    var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName)
        //        ?? throw new Exception("الفئه دي كمان مش موجوده");
        //    //Category category;

        //    //if (!string.IsNullOrWhiteSpace(dto.CategoryName))
        //    //{
        //    //    // نحاول نجيب الكاتيجوري لو موجودة
        //    //    category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);

        //    //    // لو مش موجودة، نعمل واحدة جديدة
        //    //    if (category == null)
        //    //    {
        //    //        category = new Category
        //    //        {
        //    //            Id = Guid.NewGuid().ToString(),
        //    //            Name = dto.CategoryName
        //    //        };

        //    //        _categoryRepo.Add(category);
        //    //        await _categoryRepo.SaveChangesAsync();
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    throw new Exception("اسم الفئة لا يمكن أن يكون فارغًا");
        //    //}


        //    var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName)
        //        ?? throw new Exception("الجهه الي اتكتبت مش موجوده");

        //    //DomainTeam? team = null;
        //    //if (!string.IsNullOrWhiteSpace(dto.TeamName))
        //    //{
        //    //    team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
        //    //    if (team == null)
        //    //    {
        //    //        team = new DomainTeam { Name = dto.TeamName };
        //    //        _teamRepo.Add(team);
        //    //        await _teamRepo.SaveChangesAsync();
        //    //    }
        //    //}
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

        //    var requiredSkills = new List<Skilless>();

        //    if (dto.RequiredSkillNames != null && dto.RequiredSkillNames.Any())
        //    {
        //        foreach (var skillName in dto.RequiredSkillNames)
        //        {
        //            if (string.IsNullOrWhiteSpace(skillName)) continue;

        //            var skill = await _skillRepo.FirstOrDefaultAsync(s => s.Name == skillName);
        //            if (skill == null)
        //            {
        //                skill = new Skilless
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = skillName
        //                };
        //                _skillRepo.Add(skill);
        //                await _skillRepo.SaveChangesAsync();
        //            }

        //            requiredSkills.Add(skill);
        //        }
        //    }







        //    string? savedImagePath = null;
        //    if (dto.Image != null && dto.Image.Length > 0)
        //    {
        //        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
        //        Directory.CreateDirectory(uploadsFolder); // تأكد من وجود المجلد

        //        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Image.FileName);
        //        var fullPath = Path.Combine(uploadsFolder, fileName);

        //        using var stream = new FileStream(fullPath, FileMode.Create);
        //        await dto.Image.CopyToAsync(stream, cancellationToken);

        //        savedImagePath = Path.Combine("uploads", fileName);
        //    }


        //    var opportunity = dto.Map<VolunteerOpportunity>();

        //    opportunity.Id = Guid.NewGuid().ToString();
        //    opportunity.CategoryID = category.Id;
        //    opportunity.OrganizationID = organization.Id;
        //    opportunity.TeamId = team?.Id;
        //    opportunity.Status = OpportunityStatus.Published;
        //    opportunity.Image = savedImagePath; // هنا بنحط اللينك للمسار

        //    opportunity.Organization = null;
        //    opportunity.Category = null;
        //    opportunity.Team = null;
        //    opportunity.RequiredSkills = requiredSkills;



        //    //_opportunityRepo.Add(opportunity);
        //    //await _opportunityRepo.SaveChangesAsync();
        //    try
        //    {
        //        _opportunityRepo.Add(opportunity);
        //        await _opportunityRepo.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("خطأ أثناء الحفظ: " + (ex.InnerException?.Message ?? ex.Message));

        //    }


        //    return opportunity.Map<DetailsOpportunityDto>();
        //}

















        //public async Task<DetailsOpportunityDto> Handle(AddOpportunityCommand request, CancellationToken cancellationToken)
        //{
        //    var dto = request.AddOpportunityDto;


        //    var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
        //    if (category == null)
        //        throw new Exception("الفئه دي كمان مش موجوده");


        //    var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName);
        //    if (organization == null)
        //        throw new Exception("الجهه الي اتكتبت مش موجوده");


        //    DomainTeam? team = null;
        //    if (!string.IsNullOrWhiteSpace(dto.TeamName))
        //    {
        //        team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
        //        if (team == null)
        //        {
        //            team = new DomainTeam { Name = dto.TeamName };
        //            _teamRepo.Add(team);
        //            await _teamRepo.SaveChangesAsync();
        //        }
        //    }


        //    var opportunity = dto.Map<VolunteerOpportunity>();

        //    opportunity.CategoryID = category.Id;
        //    opportunity.OrganizationID = organization.Id;
        //    opportunity.TeamId = team?.Id;
        //    opportunity.Status = OpportunityStatus.Published;

        //    _opportunityRepo.Add(opportunity);
        //    await _opportunityRepo.SaveChangesAsync();

        //    return opportunity.Map<DetailsOpportunityDto>();
        //}

    }
}


