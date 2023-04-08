using Crm.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmWeb.Controller
{
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        [HttpGet]
        public async Task<IActionResult> GetTasksAsync()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }
    }
}
