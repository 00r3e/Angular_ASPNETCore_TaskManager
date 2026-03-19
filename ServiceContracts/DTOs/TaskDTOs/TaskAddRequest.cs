using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ServiceContracts.DTOs.TaskDTOs
{
    public class TaskAddRequest
    {
        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public string Category { get; set; } = "";

        public string Priority { get; set; } = "";

        public DateTime DueDate { get; set; }

        public string Status { get; set; } = "";

        public DateTime CreatedAt { get; set; }

        public TaskItem ToTaskItem()
        {
            return new TaskItem
            {
                Title = this.Title,
                Description = this.Description,
                Category = this.Category,
                Priority = this.Priority,
                DueDate = this.DueDate,
                Status = this.Status,
                CreatedAt = this.CreatedAt
            };
        }
    }
}
