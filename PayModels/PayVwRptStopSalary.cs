using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptStopSalary
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string? BankCode { get; set; }
        public string? BranchCode { get; set; }
        public string? AccNo { get; set; }
        public string? OldBankCode { get; set; }
        public string? OldBranchCode { get; set; }
        public string? OldAccNo { get; set; }
        public decimal? OldAmount { get; set; }
        public DateTime? EffectDate { get; set; }
        public string Name { get; set; } = null!;
        public bool? Etrans { get; set; }
    }
}
