using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListPaymentAnalysis
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Initials { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public int AccPriority { get; set; }
        public string AccNo { get; set; } = null!;
        public decimal? AmtToSend { get; set; }
        public bool LoanAcc { get; set; }
        public decimal LoanAmt { get; set; }
    }
}
