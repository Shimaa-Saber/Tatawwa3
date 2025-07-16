using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class ParticipationRepository : IParticipationRepository
    {
        private readonly Tatawwa3DbContext _context;

        public ParticipationRepository(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<int> CountAsync(Expression<Func<Participation, bool>> predicate)
        {
            return await _context.Participations.CountAsync(predicate);
        }
    }
}
