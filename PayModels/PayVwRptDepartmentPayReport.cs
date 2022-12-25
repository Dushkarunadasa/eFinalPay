using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptDepartmentPayReport
    {
        public string GroupCategory { get; set; } = null!;
        public string GroupItemCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string? BankDeductionName { get; set; }
        public string? BankCode { get; set; }
        public string? BranchCode { get; set; }
        public string? BankAccountNo { get; set; }
        public string? AddressSin { get; set; }
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal? Amt { get; set; }
        public string? OfficerCodeSin { get; set; }
        public string? FullNameSin { get; set; }
        public string? IntnameSin { get; set; }
        public string? RankNameSin { get; set; }
        public string RankCode { get; set; } = null!;
        public string CurMonth { get; set; } = null!;
    }
}
