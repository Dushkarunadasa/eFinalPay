using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptPaySlipEmail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string? Descrip { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Units { get; set; }
        public int? FontSize { get; set; }
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
        public int RowId { get; set; }
        public string BaseCode { get; set; } = null!;
        public string AreaCode { get; set; } = null!;
    }
}
