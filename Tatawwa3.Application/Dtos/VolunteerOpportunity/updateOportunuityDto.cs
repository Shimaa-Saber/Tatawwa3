﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public  class updateOportunuityDto
    {
        public string Id { get; set; } // ضروري نعرف أي فرصة بنحدثها

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? RequiredVolunteers { get; set; }
        public string? CategoryName { get; set; }
        public string? OrganizationName { get; set; }
        public string? TeamName { get; set; }
        public IFormFile? Image { get; set; }
        public string? TimeAttend { get; set; }
        public bool? IsAttendanceTracked { get; set; }
        public bool? IsCertificateAvailable { get; set; }
        public int? TotalHours { get; set; }
        public Gender? GenderRequirement { get; set; }
        public List<string>? RequiredSkills { get; set; }

    }
}
