using Microsoft.AspNetCore.Mvc;

namespace CirclAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Pong from Circl API!");
    }
}

