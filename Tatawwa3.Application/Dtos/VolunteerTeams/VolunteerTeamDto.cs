using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerTeams
{
    public class VolunteerTeamDto
    {
        public Guid Id { get; set; } // لزر الانضمام

        public string Name { get; set; } = string.Empty; // اسم الفريق (أكبر عنصر)

        public string Description { get; set; } = string.Empty; // الوصف المختصر تحت الاسم

        public string Category { get; set; } = string.Empty; // المجال (مثلاً: بيئي، تعليمي...)

        public string City { get; set; } = string.Empty; // المدينة (مثلاً: القاهرة)

        public string OrganizationType { get; set; } = string.Empty; // نوع الجهة (جمعية، مؤسسة...)

        public bool IsAvailable { get; set; } // لو الفريق متاح للتقديم حاليًا
        public int MembersCount { get; set; } //  عدد الأشخاص في الفريق
    }
}
