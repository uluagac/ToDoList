using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Contexts;
using ToDoList.Core.Models;
using ToDoList.Repository.Abstracts;

namespace ToDoList.Repository.Concretes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool Authenticate(string username, string password)
        {
            return _context.Users.Any(u => u.Username == username && u.Password == password);
        }
        public User GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
        public IEnumerable<User> GetFriends(int userId)
        {
            return _context.Friendships
                .Where(f => f.RequesterId == userId || f.ReceiverId == userId)
                .Select(f => f.RequesterId == userId ? f.Receiver : f.Requester)
                .ToList();
        }
    }
}
