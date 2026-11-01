using WorkFlow.Models;
using WorkFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace WorkFlow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController: ControllerBase
    {
       private readonly TaskService _taskService;

       public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }


        [HttpGet("Count")]
        public IActionResult GetTaskCount()
        {
            int count = _taskService.GetTaskCount();

            return Ok(count);
        }
    }
}
