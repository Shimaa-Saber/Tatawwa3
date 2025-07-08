using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Tatawwa3.Application.Dtos.ApplicationDtos
{
   public class addApplicationDto
    {

        public string OpportunityID { get; set; }
        //public string VolunteerID { get; set; }
        public string MotivationLetter { get; set; }
        public bool HasRequiredSkills { get; set; }
        public IFormFile? Attachment { get; set; }
    }
}
