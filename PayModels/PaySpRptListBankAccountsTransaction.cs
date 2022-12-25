using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PaySpRptListBankAccountsTransaction
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string AccCat { get; set; } = null!;
        public int AccPriority { get; set; }
        public string BankCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string AccNo { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool LoanAcc { get; set; }
        public decimal LoanAmt { get; set; }
        public string DepnId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? PayMonth { get; set; }
        public string Mtype { get; set; } = null!;
    }
}
