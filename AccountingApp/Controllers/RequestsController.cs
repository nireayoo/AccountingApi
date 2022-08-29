using AccountingApp.Model;
using AccountingApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IUserServices userServices;

        private RequestsController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AppUserRequest model)
        {
            var response = userServices.Authenticate(model);
            if (response == null)
           
                return BadRequest(new { message = "Username or password incorrect" });

            
            return Ok(response);

        }
        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = userServices.GetAll();
            return Ok(users);
        }

      
    }
}
