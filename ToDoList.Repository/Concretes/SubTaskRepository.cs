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
    public class SubTaskRepository : BaseRepository<SubTask>, ISubTaskRepository
    {
        private readonly DbSet<SubTask> _dbSet;

        public SubTaskRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<SubTask>();
        }

        public IEnumerable<SubTask> GetSubTasksByStatus(int subTaskId, ToDoTaskStatus status)
        {
            return _dbSet.Where(subTask => subTask.Id == subTaskId && subTask.Status == status).ToList();
        }
    }
}
