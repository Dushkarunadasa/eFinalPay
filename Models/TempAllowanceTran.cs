using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class TempAllowanceTran
    {
        public string? BaseCode { get; set; }
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficialNo { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Amount { get; set; }
    }
}
