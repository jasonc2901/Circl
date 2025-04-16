using Circl.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CirclAPI.Controllers
{
    [ApiController]
    [Route("api/ping")]
    public class PingController : ControllerBase
    {
        private readonly IApplicationDbContext _dbContext;
        
        public PingController(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetPongAsync()
        {
            var testItem = await _dbContext.TestModels.FirstOrDefaultAsync();
            return Ok($"Testing the db API response: {testItem?.Name} {testItem?.Description}");
        }
    }
}

