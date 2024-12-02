using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class SubTask : BaseEntity
    {
        // Properties
        public string Name { get; set; }

        // Navigation Properties
        public User AssignedUser { get; set; }
        public int TaskId { get; set; }
        public Task ParentTask { get; set; }
    }
}
