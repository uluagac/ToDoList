using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Repository.Abstracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool Authenticate (string username, string password);
        User GetByUsername(string username);
        IEnumerable<User> GetFriends(int userId);
    }
}
