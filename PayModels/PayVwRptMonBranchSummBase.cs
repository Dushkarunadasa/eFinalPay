using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonBranchSummBase
    {
        public string BaseCode { get; set; } = null!;
        public string? BaseName { get; set; }
        public decimal? Amnt { get; set; }
        public int? Offcode { get; set; }
        public string Bankcode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
    }
}
