using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_API_Postgre_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        { 
            return Ok("I am Authorize");
        }
    }
}
