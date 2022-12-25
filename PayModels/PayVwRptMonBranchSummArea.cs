using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonBranchSummArea
    {
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public decimal? Amnt { get; set; }
        public int? Offcode { get; set; }
        public string Bankcode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
    }
}
