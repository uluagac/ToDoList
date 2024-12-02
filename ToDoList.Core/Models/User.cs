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
		public string Email
		{
			get
			{
				return _email; 
			}
			set
			{
				_email = value; 
			}
		}
        public string Username
		{
			get
			{
				return _userName;
			}
			set
			{
				_userName = value;
			}
		}
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}

        // Navigation Properties
        public ICollection<Task> Tasks { get; set; }
        public ICollection<User> FriendList { get; set; }
    }
}
