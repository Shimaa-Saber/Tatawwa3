using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerMangement
{
    public class ApplicationStatisticsDto
    {
        public int Total { get; set; }
        public int Accepted { get; set; }
        public int Rejected { get; set; }
        public int Pending { get; set; }
    }

}
