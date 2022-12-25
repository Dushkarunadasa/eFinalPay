using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchBankDeduction1
    {
        public string BankDeductionCode { get; set; } = null!;
        public string? BankDeductionName { get; set; }
        public string? BankAccountNo { get; set; }
        public string? TransactionCode { get; set; }
        public string BranchName { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string? BankCode { get; set; }
        public string? BranchCode { get; set; }
        public string? AddressSin { get; set; }
    }
}
