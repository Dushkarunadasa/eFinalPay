using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptBasewisePaySummary
    {
        public string? BaseCode { get; set; }
        public string BaseName { get; set; } = null!;
        public int? Noofperson { get; set; }
        public decimal? Consol { get; set; }
        public decimal? Fixall { get; set; }
        public decimal? Varall { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Fixdeduct { get; set; }
        public decimal? Vardeduct { get; set; }
        public decimal? NetSalary { get; set; }
    }
}
