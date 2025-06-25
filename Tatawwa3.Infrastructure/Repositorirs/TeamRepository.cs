using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class TeamRepository:GenericRepository<Team>,ITeamRepository
    {
        public TeamRepository(Tatawwa3DbContext context) : base(context)
        {
        }
    }
}
