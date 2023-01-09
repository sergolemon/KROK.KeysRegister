using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KeyEntity
    {
        public Guid Id { get; set; }
        public string AuditoryName { get; set; }
        public List<EventEntity> Events { get; set; }
        public List<KeyAuditoryTagEntity> KeyAuditoryTags { get; set; }
        public List<PermissionEntity> Permissions { get; set; }
    }
}
