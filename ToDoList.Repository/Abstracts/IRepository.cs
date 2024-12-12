using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Repository.Abstracts
{
    public interface IRepository<T> where T : BaseEntity 
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
