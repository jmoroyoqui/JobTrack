using JobTracker.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobTracker.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "CreateUser")]
        public IActionResult Create([FromBody] Users user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }
            return Ok();
        }
    }
}
