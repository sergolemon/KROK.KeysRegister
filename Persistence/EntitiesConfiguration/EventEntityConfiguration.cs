using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntitiesConfiguration
{
    public class EventEntityConfiguration : IEntityTypeConfiguration<EventEntity>
    {
        public void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            builder.ToTable("events");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("event_id");
            builder.Property(t => t.Comment).HasMaxLength(180).HasColumnName("comment");
            builder.Property(t => t.Type).HasColumnName("type");
            builder.Property(t => t.DateTime).HasColumnName("datetime");
            builder.Property(t => t.EmployeeId).HasColumnName("employee_id");
            builder.Property(t => t.KeyId).HasColumnName("key_id");
        }
    }
}
