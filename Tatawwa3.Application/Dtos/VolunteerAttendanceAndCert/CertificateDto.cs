using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert
{
    public class CertificateDto
    {
        public string Title { get; set; }         
        public float TotalHours { get; set; }      
        public DateTime IssueDate { get; set; }    
        public string OrganizationName { get; set; } 
        public string DownloadUrl { get; set; }   
    }


}
