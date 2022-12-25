using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPayItem
    {
        public string ItemCode { get; set; } = null!;
        public string? ItemCat { get; set; }
        public string? ItemDescription { get; set; }
        public int Unit { get; set; }
        public decimal? Amount { get; set; }
        public bool? DaysCal { get; set; }
    }
}
