using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AuditoryTagEntity
    {
        public Guid Id { get; set; }
        public string Tag { get; set; }
        public List<KeyAuditoryTagEntity> KeyAuditoryTags { get; set; }
    }
}
