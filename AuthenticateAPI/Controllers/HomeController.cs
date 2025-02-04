using AuthenticateAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("getuser")]
        public IActionResult Get()
        {
            var result = SeedData.GetUsers();
            return Ok(result);
        }
    }
}
