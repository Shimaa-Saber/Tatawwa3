﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class VolunteerProfileRepository:GenericRepository<VolunteerProfile>,IVolunteerProfileRepository
    {
        private readonly Tatawwa3DbContext _context;
        public VolunteerProfileRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<float> GetTotalHoursAsync()
        {
            return await _context.VolunteerProfiles.SumAsync(v => v.TotalHours);
        }
    }
}
