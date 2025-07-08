using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class UpdateTeamDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } 

    }
}
