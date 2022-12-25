using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonBranchSumm
    {
        public string Syscode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public decimal? Amnt { get; set; }
        public int? OffCode { get; set; }
        public string BaseCode { get; set; } = null!;
        public string? AreaCode { get; set; }
        public string? BaseName { get; set; }
        public string? AreaName { get; set; }
    }
}
