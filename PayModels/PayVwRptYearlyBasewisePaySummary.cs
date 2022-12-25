using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptYearlyBasewisePaySummary
    {
        public string? BaseCode { get; set; }
        public string BaseName { get; set; } = null!;
        public decimal? Amount { get; set; }
        public string? Mmonth { get; set; }
        public string Amttype { get; set; } = null!;
    }
}
