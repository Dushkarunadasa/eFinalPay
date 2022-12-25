using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptBankRemitanceBreakDown
    {
        public string SysCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal? Amt { get; set; }
    }
}
