using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptAdvanceAccount40Per
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string Mname { get; set; } = null!;
        public string Rankname { get; set; } = null!;
        public decimal? Grosspay { get; set; }
        public decimal? Per40 { get; set; }
        public decimal? LnternalLoan { get; set; }
        public decimal? Bankloan { get; set; }
        public decimal? BalanceLoanAmt { get; set; }
    }
}
