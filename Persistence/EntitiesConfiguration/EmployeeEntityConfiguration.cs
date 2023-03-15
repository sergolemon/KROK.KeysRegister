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
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.ToTable("employees");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("employee_id");
            builder.Property(t => t.Name).HasMaxLength(90).HasColumnName("name");
            builder.Property(t => t.Surname).HasMaxLength(90).HasColumnName("surname");
            builder.Property(t => t.Patronymic).HasMaxLength(90).HasColumnName("patronymic");
            builder.Property(t => t.Avatar).HasColumnName("avatar");
        }
    }
}
