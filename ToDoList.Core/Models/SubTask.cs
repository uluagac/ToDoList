using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Enums;

namespace ToDoList.Core.Models
{
    public class SubTask : BaseEntity
    {
        // Properties
        public string Title { get; set; }

        // Enums
        public ToDoTaskStatus Status { get; set; } = ToDoTaskStatus.Continue;

        // Navigation Properties
        public int? AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public int TaskId { get; set; }
        public ToDoTask ParentTask { get; set; }
    }
}
