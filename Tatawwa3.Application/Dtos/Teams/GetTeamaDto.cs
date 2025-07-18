﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class GetTeamaDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? OrganizationName { get; set; }
        public int CurrentMembersCount { get; set; }
        public string? City { get; set; }
        public string? CategoryName { get; set; }

    }
}
