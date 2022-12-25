using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptBankAdvice
    {
        public string OfficerCode { get; set; } = null!;
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BarnchCode { get; set; } = null!;
        public string AccNo { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal? AmtToSend { get; set; }
        public string? Desc1 { get; set; }
        public string? Desc2 { get; set; }
        public string? Desc3 { get; set; }
        public string? Desc4 { get; set; }
        public string? Desc5 { get; set; }
        public int? Month { get; set; }
        public string? Year { get; set; }
        public string SysCode { get; set; } = null!;
        public bool Etrans { get; set; }
        public string BranchName { get; set; } = null!;
    }
}
