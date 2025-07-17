using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Http;


namespace Tatawwa3.Application.Hubs
{
    public class ReviewHub : Hub
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ReviewHub(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var opportunityId = httpContext.Request.Query["opportunityId"];

            await Groups.AddToGroupAsync(Context.ConnectionId, opportunityId);
            await base.OnConnectedAsync();
        }
        
    }
}
