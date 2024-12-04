using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class Task : BaseEntity
    {
        // Properties
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CompletionDate { get; set; }

        // Navigation Properties
        public ICollection<SubTask> SubTasks { get; set; }
    }
}
