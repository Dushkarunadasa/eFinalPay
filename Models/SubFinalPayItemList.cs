using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPayItemList
    {
        public int TransId { get; set; }
        public int UnitId { get; set; }
        public string? Base { get; set; }
        public string ItemCode { get; set; } = null!;
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
        public bool? FromGratuity { get; set; }
        public string? Remarks { get; set; }
    }
}
