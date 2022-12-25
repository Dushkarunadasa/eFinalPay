using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonPaySummary
    {
        public int RowId { get; set; }
        public string SysCode { get; set; } = null!;
        public string SysCatName { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string CatName { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string OfficerName { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string BaseName { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public decimal Amount { get; set; }
        public string ItemAltName { get; set; } = null!;
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
        public string AreaCode { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string SubUnitCode { get; set; } = null!;
        public string SubUnitName { get; set; } = null!;
    }
}
