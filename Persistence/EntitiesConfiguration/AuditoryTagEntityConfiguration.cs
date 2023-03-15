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
    public class AuditoryTagEntityConfiguration : IEntityTypeConfiguration<AuditoryTagEntity>
    {
        public void Configure(EntityTypeBuilder<AuditoryTagEntity> builder)
        {
            builder.ToTable("auditory_tags");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("auditory_tag_id");
            builder.Property(t => t.Tag).HasMaxLength(90).HasColumnName("tag");
        }
    }
}
