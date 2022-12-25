using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubRoleAllowance
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? BaseCode { get; set; }
        public int Unit { get; set; }
        public bool Active { get; set; }
        public DateTime ActiveOn { get; set; }
        public DateTime? DeactiveOn { get; set; }
    }
}
