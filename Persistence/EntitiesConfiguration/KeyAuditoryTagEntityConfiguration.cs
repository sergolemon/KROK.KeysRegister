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
    public class KeyAuditoryTagEntityConfiguration : IEntityTypeConfiguration<KeyAuditoryTagEntity>
    {
        public void Configure(EntityTypeBuilder<KeyAuditoryTagEntity> builder)
        {
            builder.ToTable("key_auditory_tags");
            builder.HasKey(t => t.Id);
            builder.HasAlternateKey(t => new { t.KeyId, t.AuditoryTagId });
            builder.Property(t => t.Id).HasColumnName("key_auditory_tag_id");
            builder.Property(t => t.AuditoryTagId).HasColumnName("auditory_tag_id");
            builder.Property(t => t.KeyId).HasColumnName("key_id");
        }
    }
}
