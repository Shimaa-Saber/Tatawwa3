using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using Tatawwa3.Domain.Enums.Team;
namespace Tatawwa3.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamJoinPermission
    {
        Anyone=0,              
        InvitationOnly=1 
    }
}
