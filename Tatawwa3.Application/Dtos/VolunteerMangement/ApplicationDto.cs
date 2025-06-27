using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerMangement
{
    public class ApplicationDto
    {
        public string VolunteerId { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public DateTime AppliedAt { get; set; }
    }
}
