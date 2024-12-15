using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class User : BaseEntity
    {
        // Fields
        private string _email;
        private string _username;
        private string _password;

        // Constructor
        public User()
        {

        }

        // Properties
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                    _email = value.Trim();
                throw new ArgumentException("Girilen değer bir e-posta gerekliliklerini içermiyor!");
            }
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Contains(" "))
                    throw new ArgumentException("Kullanıcı adı boşluk içeremez!");
                _username = value.Trim();
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
                if (value.Contains(" "))
                    throw new ArgumentException("Parola boşluk içeremez!");
                else
                {
                    if (value.Length >= 6 && value.Any(char.IsDigit) && value.Any(char.IsLower) && value.Any(char.IsUpper))
                        _password = value.Trim();
                    throw new ArgumentException("Parola en az bir rakam, bir küçük harf ve bir büyük harf içermelidir!");
                }
            }
        }

        // Navigation Properties
        public ICollection<ToDoTask> ToDoTasks { get; set; } = new List<ToDoTask>();
        public ICollection<SubTask> SubTasks { get; set; } = new List<SubTask>();
        public ICollection<Friendship> SentFriendRequests { get; set; }
        public ICollection<Friendship> ReceivedFriendRequests { get; set; }

    }
}
