using AccountingApp.Model;
using AccountingApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestRepository requestRepository;

        public RequestsController(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }
      
    }
}
