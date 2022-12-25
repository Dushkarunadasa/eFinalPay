using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubRoleTypeAllowance
    {
        public int RoleGroup { get; set; }
        public int RoleOrder { get; set; }
        public string Role { get; set; } = null!;
    }
}
