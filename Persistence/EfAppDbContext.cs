using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class EfAppDbContext : DbContext
    {
        public EfAppDbContext(DbContextOptions<EfAppDbContext> opts) : base(opts)
        {
             
        }

        public DbSet<AuditoryTagEntity> AuditoryTags { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<KeyAuditoryTagEntity> KeyAuditoryTags { get; set; }
        public DbSet<KeyEntity> Keys { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {


            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
