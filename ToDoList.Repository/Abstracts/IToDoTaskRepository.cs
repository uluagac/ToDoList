using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Enums;
using ToDoList.Core.Models;

namespace ToDoList.Repository.Abstracts
{
    public interface IToDoTaskRepository : IBaseRepository<ToDoTask>
    {
        IEnumerable<ToDoTask> GetUserTasks(int userId);
        IEnumerable<ToDoTask> GetTasksByStatus(int userId, ToDoTaskStatus status);
        IEnumerable<ToDoTask> GetTasksByDueDate(int userId, DateTime dueDate);
        ToDoTask GetTaskWithSubTasks(int taskId);
    }
}
