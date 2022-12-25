using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAllowancesSubject
    {
        public int SubId { get; set; }
        public string? Subject { get; set; }
        public int? Type { get; set; }
    }
}
