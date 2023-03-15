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
    public class PermissionEntityConfiguration : IEntityTypeConfiguration<PermissionEntity>
    {
        public void Configure(EntityTypeBuilder<PermissionEntity> builder)
        {
            builder.ToTable("permissions");
            builder.HasKey(t => t.Id);
            builder.HasAlternateKey(t => new { t.KeyId, t.EmployeeId });
            builder.Property(t => t.Id).HasColumnName("permission_id"); 
            builder.Property(t => t.EmployeeId).HasColumnName("employee_id");
            builder.Property(t => t.KeyId).HasColumnName("key_id");
        }
    }
}
