using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Core.Configs
{
    public class ToDoTaskConfig : IEntityTypeConfiguration<ToDoTask>
    {
        public void Configure(EntityTypeBuilder<ToDoTask> builder)
        {
            // Relationships
            builder.HasOne(toDoTask => toDoTask.AssignedUser).WithMany(user => user.ToDoTasks).HasForeignKey(toDoTask => toDoTask.AssignedUserId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(toDoTask => toDoTask.Status).HasConversion<string>();

            // Ignore
            builder.Ignore(toDoTask => toDoTask.IsDeleted);
        }
    }
}
