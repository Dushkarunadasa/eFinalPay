using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonPaySumm
    {
        public int? RowId { get; set; }
        public string? SysCode { get; set; }
        public string? SysCatName { get; set; }
        public string? CatCode { get; set; }
        public string? CatName { get; set; }
        public string? OfficerCode { get; set; }
        public string? OfficerName { get; set; }
        public string? BaseCode { get; set; }
        public string? BaseName { get; set; }
        public string? ItemCategory { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Amount { get; set; }
        public string? ItemAltName { get; set; }
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public string? RankCode { get; set; }
        public string? RankName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? SubUnitCode { get; set; }
        public string? SubUnitName { get; set; }
    }
}
