using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubLog
    {
        public string LuserId { get; set; } = null!;
        public string Ldescription { get; set; } = null!;
        public DateTime LogOn { get; set; }
        public string? Ipaddress { get; set; }
    }
}
