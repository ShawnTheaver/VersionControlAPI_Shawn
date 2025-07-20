using Microsoft.AspNetCore.Mvc;

namespace VersionControlAPI_Shawn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Sudharshan Theaver" });
        }
    }
}
