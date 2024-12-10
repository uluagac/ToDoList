using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;
using ToDoList.Repository.Abstracts;

namespace ToDoList.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public int Add(T entity)
        {
            throw new NotImplementedException();
        }
        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public ICollection<T> GetById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
