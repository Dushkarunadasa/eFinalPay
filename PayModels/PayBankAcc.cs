using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBankAcc
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string AccCat { get; set; } = null!;
        public int AccPriority { get; set; }
        public string BankCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string AccNo { get; set; } = null!;
        /// <summary>
        /// If not salary account the amount should be percentage and &gt;=100
        /// </summary>
        public decimal Amount { get; set; }
        public bool LoanAcc { get; set; }
        public decimal LoanAmt { get; set; }
        /// <summary>
        /// &apos;&apos;
        /// </summary>
        public string DepnId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? PayMonth { get; set; }
        public byte[]? Trorder { get; set; }
        public string? Remark { get; set; }
    }
}
