using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KeyAuditoryTagEntity
    {
        public Guid Id { get; set; }
        public Guid KeyId { get; set; }
        public KeyEntity Key { get; set; }
        public Guid AuditoryTagId { get; set; }
        public AuditoryTagEntity AuditoryTag { get; set; }
    }
}
