using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Attendace
{
    public class UpdateOpportunityAttendancesDto
    {
        public string OpportunityId { get; set; } = null!;
        public List<UpdateAttendanceDto> Attendances { get; set; } = new();
    }
}
