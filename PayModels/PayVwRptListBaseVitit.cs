using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListBaseVitit
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string Basename { get; set; } = null!;
        public string? BaseSubCode { get; set; }
        public DateTime VisitDateFrom { get; set; }
        public DateTime? DisitDateTo { get; set; }
        public string Signal { get; set; } = null!;
        public string? OldBaseCode { get; set; }
        public string? Oldbasename { get; set; }
        public string? PayMonth { get; set; }
        public int? Torder { get; set; }
        public int? Userid { get; set; }
    }
}
