using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PermissionEntity
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; }
        public Guid KeyId { get; set; }
        public KeyEntity Key { get; set; }
    }
}
