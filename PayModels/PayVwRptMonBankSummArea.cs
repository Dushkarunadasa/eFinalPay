using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonBankSummArea
    {
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public decimal? Amnt { get; set; }
        public int? Offcode { get; set; }
    }
}
