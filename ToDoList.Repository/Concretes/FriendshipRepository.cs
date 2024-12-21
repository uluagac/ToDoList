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
    public class FriendshipRepository : BaseRepository<Friendship>, IFriendshipRepository
    {
        public FriendshipRepository(AppDbContext context) : base(context)
        {
        }
    }
}
