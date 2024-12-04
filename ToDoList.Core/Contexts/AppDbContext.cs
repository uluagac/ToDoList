using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Core.Contexts
{
    public class AppDbContext : DbContext
    {
        // Properties
        public DbSet<User> Users { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        //
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoList;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.CreatedDate).HasColumnName("UyelikTarihi");
                entity.Property(u => u.UpdatedDate).HasColumnName("SilinmeTarihi");
                entity.Property(u => u.IsDeleted).HasColumnName("Silinmis");
                
                entity.HasIndex(u => u.Email).IsUnique(true);
                entity.Property(u => u.Email).IsRequired(true).HasColumnType("nvarchar(50)").HasColumnName("E-Posta");
                
                entity.HasIndex(u => u.Username).IsUnique(true);
                entity.Property(u => u.Username).IsRequired(true).HasColumnType("nvarchar(25)").HasColumnName("KullaniciAdı");
                
                entity.Property(u => u.Password).IsRequired(true).HasColumnType("nvarchar(max)").HasColumnName("Parola");

                //entity.Property(u => u.Tasks).IsRequired(false).HasColumnName("Gorevler");
                //entity.Property(u => u.FriendList).IsRequired(false).HasColumnName("ArkadasListesi");

            });

            modelBuilder.Entity<Models.Task>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.CreatedDate).HasColumnName("OlusturmaTarihi");
                entity.Property(t => t.UpdatedDate).HasColumnName("GuncellemeTarihi");
                entity.Property(t => t.IsDeleted).HasColumnName("Silinmis");

                entity.Property(t => t.Title).IsRequired(true).HasColumnType("nvarchar(128)").HasColumnName("Gorev");

                entity.Property(t => t.Description).IsRequired(false).HasColumnType("nvarchar(256)").HasColumnName("Aciklama");

                entity.Property(t => t.CompletionDate).IsRequired(false).HasColumnName("BitirmeTarihi");

                //entity.Property(t => t.SubTasks).IsRequired(false).HasColumnName("AltGorevler");
            });

            modelBuilder.Entity<SubTask>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.CreatedDate).HasColumnName("OlusturmaTarihi");
                entity.Property(s => s.UpdatedDate).HasColumnName("GuncellemeTarihi");
                entity.Property(s => s.IsDeleted).HasColumnName("Silinmis");

                entity.Property(s => s.Title).IsRequired(true).HasColumnType("nvarchar(128)").HasColumnName("AltGorev");

                //entity.Property(s => s.AssignedUserId).IsRequired(false).HasColumnName("GorevliId");
                entity.HasOne(s => s.AssignedUser).WithMany().HasForeignKey(s => s.AssignedUserId);

                //entity.Property(s => s.TaskId).IsRequired(true).HasColumnName("UstGorevId");
                entity.HasOne(s => s.ParentTask).WithMany(t => t.SubTasks).HasForeignKey(s => s.TaskId);
            });
        }
    }
}
