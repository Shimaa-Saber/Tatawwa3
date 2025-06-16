using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
            [HttpGet]
            public IActionResult Get() => Ok("API is working ✅");
        
    }
}
