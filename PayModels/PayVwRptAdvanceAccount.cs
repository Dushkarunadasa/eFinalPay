using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptAdvanceAccount
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string Mname { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public string? ItemCode { get; set; }
        public string? ItemCategory { get; set; }
        public string? ItemName { get; set; }
        public decimal? Amount { get; set; }
        public string? ItemGroup { get; set; }
        public string? BankCode { get; set; }
        public string? BranchCode { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? Accno { get; set; }
        public int? UserId { get; set; }
    }
}
