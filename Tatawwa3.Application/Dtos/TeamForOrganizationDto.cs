using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos
{
    public class TeamForOrganizationDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MembersCount { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
