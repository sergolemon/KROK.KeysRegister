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
    public class KeyEntityConfiguration : IEntityTypeConfiguration<KeyEntity>
    {
        public void Configure(EntityTypeBuilder<KeyEntity> builder)
        {
            builder.ToTable("keys");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("key_id");
            builder.Property(t => t.AuditoryName).HasMaxLength(30).HasColumnName("auditory_name");
        }
    }
}
