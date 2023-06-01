using EmailCodeCheckIn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmailCodeCheckIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInController : ControllerBase
    {
        private readonly CodeCheckInContext _dbContext;

        public CheckInController(CodeCheckInContext dbContext)
        {
            _dbContext = dbContext;
        }
        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<CodeCheckIn>>> GetData()
        //    {
        //        if (_dbContext == null)
        //        {
        //            return NotFound();
        //        }
        //        return await _dbContext.CodeCheckIn.ToListAsync();
        //    }
        //}
    }
}
