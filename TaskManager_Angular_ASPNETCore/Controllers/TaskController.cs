using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTOs.TaskDTOs;
using Servicies;

namespace TaskManager_Angular_ASPNETCore.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {

        private readonly ITaskservice _taskService;

        public TaskController(ITaskservice service)
        {
            _taskService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {

            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(int id)
        {
            var task = await _taskService.GetTaskAsync(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(TaskAddRequest taskAddRequest)
        {
            var task = await _taskService.CreateTaskAsync(taskAddRequest);
            return Ok(task);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskUpdateRequest dto)
        {
            var taskResponse = await _taskService.GetTaskAsync(id);
            if (taskResponse == null) return NotFound();
            var updatedTaskresponse = await _taskService.UpdateTaskAsync(id, dto);
            return Ok(updatedTaskresponse);
        }

        [HttpPatch("{id}/toggle")]
        public async Task<IActionResult> toggleTask(int id)
        {
            var taskResponse = await _taskService.GetTaskAsync(id);
            if (taskResponse == null) return NotFound();
            taskResponse.Status = taskResponse.Status == "completed" ? "pending" : "completed";
            TaskUpdateRequest taskUpdateRequest = new TaskUpdateRequest
            {
                Title = taskResponse.Title,
                Description = taskResponse.Description,
                Category = taskResponse.Category,
                Priority = taskResponse.Priority,
                DueDate = taskResponse.DueDate,
                Status = taskResponse.Status
            };
            var updatedTaskresponse = await _taskService.UpdateTaskAsync(id, taskUpdateRequest);
            return Ok(updatedTaskresponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var taskResponse = await _taskService.DeleteTaskAsync(id);
            if (taskResponse == -1) return NotFound();
            return NoContent();
        }
    }
}
