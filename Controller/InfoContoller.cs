using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Quiz.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InfoContoller: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("I am Authorize");
        }
    }
}
