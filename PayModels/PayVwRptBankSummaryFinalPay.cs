using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptBankSummaryFinalPay
    {
        public string SysCode { get; set; } = null!;
        public bool Etrans { get; set; }
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public decimal? Amount { get; set; }
        public int? NoOfPersons { get; set; }
    }
}
