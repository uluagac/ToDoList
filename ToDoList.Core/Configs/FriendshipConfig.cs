using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Core.Configs
{
    public class FriendshipConfig : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            // Composite Primary Key
            builder.HasKey(f => new { f.RequesterId, f.ReceiverId });

            // Foreign Key Relationships
            builder.HasOne(f => f.Requester).WithMany(u => u.SentFriendRequests).HasForeignKey(f => f.RequesterId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(f => f.Receiver).WithMany(u => u.ReceivedFriendRequests).HasForeignKey(f => f.ReceiverId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(f => f.Status).HasConversion<string>();

            // Index
            builder.HasIndex(f => f.RequesterId);
            builder.HasIndex(f => f.ReceiverId);

            // Ignore
            builder.Ignore(f => f.Id);
            builder.Ignore(f => f.IsDeleted);
        }
    }
}
