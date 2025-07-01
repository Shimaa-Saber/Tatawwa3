using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Enums
{
    public enum OrganizationStatus
    {
        Pending = 0,      // قيد المراجعة
        Approved = 1,     // مفعلة
        Rejected = 2      // مرفوضة
    }
}
