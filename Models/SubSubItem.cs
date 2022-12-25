using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubSubItem
    {
        public int SubjectId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string? LogId { get; set; }
    }
}
