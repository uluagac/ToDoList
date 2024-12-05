using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Enums;

namespace ToDoList.Core.Models
{
    public class Friendship : BaseEntity
    {
        // Keys
        public int RequesterId { get; set; }
        public User Requester { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }

        // Enum
        public FriendshipStatus Status { get; set; } = FriendshipStatus.Pending;
    }
}
