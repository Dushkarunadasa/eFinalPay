using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListBankAdvice
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string BankCode { get; set; } = null!;
        public string BarnchCode { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? Name { get; set; }
        public int AccPriority { get; set; }
        public string? AccNo { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
    }
}
