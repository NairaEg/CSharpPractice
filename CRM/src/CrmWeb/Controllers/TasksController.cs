using Microsoft.AspNetCore.Mvc;

namespace CrmWeb.Controller
{
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Index()
        {
            return Ok("Working");
        }
    }
}
