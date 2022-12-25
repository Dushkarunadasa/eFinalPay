using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptSalaryValidation
    {
        public string? CatCode { get; set; }
        public string? RankCode { get; set; }
        public string? RankGroup { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemCategory { get; set; }
        public decimal? Amount { get; set; }
        public string? SysCode { get; set; }
        public string? OfficerCode { get; set; }
        public decimal? PayAmount { get; set; }
        public string ItemName { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public string? Name { get; set; }
    }
}
