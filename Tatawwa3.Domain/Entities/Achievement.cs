using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class Achievement
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequiredHours { get; set; }
        public string BadgeImage { get; set; }
    }
}
