using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Enums;
using ToDoList.Core.Models;

namespace ToDoList.Repository.Abstracts
{
    public interface ISubTaskRepository : IBaseRepository<SubTask>
    {
        IEnumerable<SubTask> GetSubTasksByStatus(int subTaskId, ToDoTaskStatus status);
    }
}
