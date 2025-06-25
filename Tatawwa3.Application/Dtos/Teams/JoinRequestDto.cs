using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class JoinRequestDto
    {
        public string TeamId { get; set; }
      
        public string Motivation { get; set; }
        public bool HasPreviousExperience { get; set; }
        public List<string>? Skills { get; set; }
    }
}
