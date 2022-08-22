using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        [Authorize(Roles ="")]
       public IActionResult Result()
        {
            return Ok("Hello");
        }
      
    }
}
