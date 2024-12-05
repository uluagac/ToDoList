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
    public class SubTaskConfig : IEntityTypeConfiguration<SubTask>
    {
        public void Configure(EntityTypeBuilder<SubTask> builder)
        {
            // Relationships
            builder.HasOne(subTask => subTask.ParentTask).WithMany(toDoTask => toDoTask.SubTasks).HasForeignKey(subTask => subTask.TaskId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(subTask => subTask.AssignedUser).WithMany(user => user.SubTasks).HasForeignKey(subTask => subTask.AssignedUserId).OnDelete(DeleteBehavior.NoAction);

            // Ignore
            builder.Ignore(subTask => subTask.IsDeleted);
        }
    }
}
