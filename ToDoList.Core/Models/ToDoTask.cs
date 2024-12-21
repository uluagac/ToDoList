using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Enums;

namespace ToDoList.Core.Models
{
    public class ToDoTask : BaseEntity
    {
        // Properties
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletionDate { get; set; }

        // Enum
        public ToDoTaskStatus Status { get; set; } = ToDoTaskStatus.Continue;

        // Navigation Properties
        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
        public ICollection<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }
}
