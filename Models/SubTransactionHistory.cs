using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubTransactionHistory
    {
        public string TransId { get; set; } = null!;
        public int? SubjectId { get; set; }
        public double PayMonth { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool? Process { get; set; }
        public decimal? PrcoessAmount { get; set; }
        public bool? ProcessAmtChanged { get; set; }
        public string? Remarks { get; set; }
    }
}
