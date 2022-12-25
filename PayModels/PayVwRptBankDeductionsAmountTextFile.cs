using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptBankDeductionsAmountTextFile
    {
        public string BankDeductionCode { get; set; } = null!;
        public string? BankDeductionName { get; set; }
        public string? BankCode { get; set; }
        public string? BranchCode { get; set; }
        public string? BankAccountNo { get; set; }
        public string? TransactionCode { get; set; }
        public string ItemCategory { get; set; } = null!;
        public decimal? Amount { get; set; }
        public string? Syscode { get; set; }
    }
}
