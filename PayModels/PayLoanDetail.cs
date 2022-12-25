using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayLoanDetail
    {
        public string SysCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public decimal? LoanAmount { get; set; }
        public decimal? NoInstall { get; set; }
        public decimal? MonthInstall { get; set; }
        public decimal? RecAmount { get; set; }
        public DateTime? LoanDate { get; set; }
        public bool? Reduce { get; set; }
        public bool? SysControl { get; set; }

        public virtual PayItem ItemC { get; set; } = null!;
        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
    }
}
