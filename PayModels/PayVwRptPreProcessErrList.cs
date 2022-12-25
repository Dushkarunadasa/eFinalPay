using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptPreProcessErrList
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public int? ErrCode { get; set; }
        public string? ErrDesc { get; set; }
        public decimal? Rate { get; set; }
    }
}
