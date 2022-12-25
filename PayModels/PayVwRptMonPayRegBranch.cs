using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonPayRegBranch
    {
        public int? RowId { get; set; }
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? ItemAltName { get; set; }
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
        public decimal? Amount { get; set; }
    }
}
