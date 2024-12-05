using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Configs;
using ToDoList.Core.Models;

namespace ToDoList.Core.Contexts
{
    public class AppDbContext : DbContext
    {
        // Properties
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Friendship> Friendships { get; set; }

        //
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoList;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FriendshipConfig());
            modelBuilder.ApplyConfiguration(new SubTaskConfig());
            modelBuilder.ApplyConfiguration(new ToDoTaskConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
