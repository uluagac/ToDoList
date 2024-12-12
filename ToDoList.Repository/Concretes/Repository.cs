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
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public int Add(T entity)
        {
            _context.Add(entity);
            return _context.SaveChanges();
        }
        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public T GetById(int id)
        {
            return _context.Find(id);
        }
        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
