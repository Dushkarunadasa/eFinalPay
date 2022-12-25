using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonSalReconSum
    {
        public int Seq { get; set; }
        public string Category { get; set; } = null!;
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string YearMonth { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? Amt { get; set; }
        public string? OfficerfName { get; set; }
        public string? Basecode { get; set; }
        public string? BaseName { get; set; }
        public string? Area { get; set; }
        public string? AreaName { get; set; }
    }
}
