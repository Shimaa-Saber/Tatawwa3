using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.AdminDashbord
{
    public class StatisticsDto
    {
        public int Users { get; set; }
        public int Volunteers { get; set; }
        public int Organizations { get; set; }
        public int Opportunities { get; set; }
        public int TotalHours { get; set; }
        public int Reviews { get; set; }
        public int Certificates { get; set; }
    }
}
