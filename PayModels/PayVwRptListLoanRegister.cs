using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListLoanRegister
    {
        public string SysCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Item { get; set; } = null!;
        public decimal? LoanAmount { get; set; }
        public decimal? NoInstall { get; set; }
        public decimal? MonthInstall { get; set; }
        public DateTime? LoanDate { get; set; }
        public decimal? RecAmount { get; set; }
        public string? Name { get; set; }
        public string? ItemName { get; set; }
        public string? BaseCode { get; set; }
    }
}
