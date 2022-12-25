using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListEmpBankAccount
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string AccCat { get; set; } = null!;
        public int AccPriority { get; set; }
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string AccNo { get; set; } = null!;
        public decimal Amount { get; set; }
        public string LoanAcc { get; set; } = null!;
        public decimal LoanAmt { get; set; }
        public string DepnId { get; set; } = null!;
        public string Active { get; set; } = null!;
        public DateTime? PayMonth { get; set; }
        public byte[]? Trorder { get; set; }
        public string? Remark { get; set; }
    }
}
