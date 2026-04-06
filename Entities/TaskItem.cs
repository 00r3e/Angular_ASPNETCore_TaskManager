using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Identity;

namespace Entities
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public string Category { get; set; } = "";

        public string Priority { get; set; } = "";

        public DateTime DueDate { get; set; }

        public string Status { get; set; } = "";

        public DateTime CreatedAt { get; set; }

        //FOREIGN KEY
        public Guid UserId { get; set; }

        //NAVIGATION PROPERTY
        public ApplicationUser User { get; set; }
    }
}
