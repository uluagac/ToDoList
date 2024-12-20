using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Contexts;
using ToDoList.Core.Enums;
using ToDoList.Core.Models;
using ToDoList.Repository.Abstracts;

namespace ToDoList.Repository.Concretes
{
    public class ToDoTaskRepository : BaseRepository<ToDoTask>, IToDoTaskRepository
    {
        private readonly DbSet<ToDoTask> _dbSet;

        public ToDoTaskRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<ToDoTask>();
        }

        public IEnumerable<ToDoTask> GetUserTasks(int userId)
        {
            return _dbSet.Where(task => task.AssignedUserId == userId).ToList();
        }
        public IEnumerable<ToDoTask> GetTasksByStatus(int userId, ToDoTaskStatus status)
        {
            return _dbSet.Where(task => task.AssignedUserId == userId && task.Status == status).ToList();
        }
        public IEnumerable<ToDoTask> GetTasksByDueDate(int userId, DateTime dueDate)
        {
            return _dbSet.Where(task => task.AssignedUserId == userId && task.DueDate == dueDate).ToList();
        }
        public ToDoTask GetTaskWithSubTasks(int taskId)
        {
            return _dbSet.Include(task => task.SubTasks).FirstOrDefault(task => task.Id == taskId);
        }

    }
}
