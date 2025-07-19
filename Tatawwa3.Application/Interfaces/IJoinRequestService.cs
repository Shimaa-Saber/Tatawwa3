using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Interfaces
{
    public interface IJoinRequestService
    {
        Task<string> AcceptJoinRequestAsync(string requestId);
        Task<string> RejectJoinRequestAsync(string requestId);
    }
}
