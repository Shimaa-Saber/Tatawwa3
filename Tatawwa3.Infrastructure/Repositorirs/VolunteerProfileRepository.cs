using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class VolunteerProfileRepository:GenericRepository<VolunteerProfile>,IVolunteerProfileRepository
    {
        public VolunteerProfileRepository(Tatawwa3DbContext context) : base(context)
        {
        }
    }
}
