using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.ViewModels
{
    internal class TeamViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }  
        public DateTime CreationDate { get; set; }
    }
}
