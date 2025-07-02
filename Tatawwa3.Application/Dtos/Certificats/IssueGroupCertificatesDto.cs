using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Certificats
{
    public class IssueGroupCertificatesDto
    {
        public string OpportunityId { get; set; }
        public string Title { get; set; }
        public string Issuer { get; set; }
        public float TotalHours { get; set; }
    }

}
