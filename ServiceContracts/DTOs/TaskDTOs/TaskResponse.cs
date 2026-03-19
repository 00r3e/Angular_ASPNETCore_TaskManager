using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ServiceContracts.DTOs.TaskDTOs
{
    public class TaskResponse
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public string Category { get; set; } = "";

        public string Priority { get; set; } = "";

        public DateTime DueDate { get; set; }

        public string Status { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }

    public static class TaskResponseExtensions
    {
        public static TaskResponse ToTaskResponse(this TaskItem task)
        {
            return new TaskResponse
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Category = task.Category,
                Priority = task.Priority,
                DueDate = task.DueDate,
                Status = task.Status,
                CreatedAt = task.CreatedAt
            };
        }
    }
}
