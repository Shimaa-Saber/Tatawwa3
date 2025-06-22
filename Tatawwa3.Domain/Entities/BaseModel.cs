using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class BaseModel
    {
        
            public string Id { get; set; }
            public bool IsDeleted { get; set; } = false;

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

            [ForeignKey(nameof(ApplicationUser))]
            public string? CreatedBy { get; set; }
            public ApplicationUser ApplicationUser { get; set; }
        }
    }

