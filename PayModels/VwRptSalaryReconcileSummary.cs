using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class VwRptSalaryReconcileSummary
    {
        public string SysCode { get; set; } = null!;
        public string? Area { get; set; }
        public decimal Consol { get; set; }
        public decimal Fixall { get; set; }
        public decimal Varall { get; set; }
        public decimal Gross { get; set; }
        public decimal Fixdeduct { get; set; }
        public decimal Vardeduct { get; set; }
        public decimal NetSalary { get; set; }
        public decimal SenttoBank { get; set; }
        public string AreaName { get; set; } = null!;
        public int? Nofoperson { get; set; }
    }
}
