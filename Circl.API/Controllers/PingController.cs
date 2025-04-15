using Microsoft.AspNetCore.Mvc;

namespace CirclAPI.Controllers
{
    [ApiController]
    [Route("api/ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPongAsync()
        {
            return Ok("Testing the pong API response!!!");
        }
    }
}

