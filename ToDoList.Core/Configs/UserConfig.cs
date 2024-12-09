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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.Username).HasColumnType("nvarchar(20)");
            builder.Property(user => user.Email).HasColumnType("nvarchar(50)");
            builder.HasIndex(user => user.Email).IsUnique();
        }
    }
}
