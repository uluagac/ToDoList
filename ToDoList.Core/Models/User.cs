using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class User : BaseEntity
    {
        // Properties
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Navigation Properties
        public ICollection<Task> Tasks { get; set; }
        public ICollection<User> FriendList { get; set; }
    }
}
