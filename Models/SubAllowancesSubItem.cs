using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAllowancesSubItem
    {
        public int SubjectId { get; set; }
        public string ItemCode { get; set; } = null!;
        public int? Type { get; set; }
    }
}
