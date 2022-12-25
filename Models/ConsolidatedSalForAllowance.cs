using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class ConsolidatedSalForAllowance
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public decimal? Rate { get; set; }
        public int ItemCode { get; set; }
    }
}
