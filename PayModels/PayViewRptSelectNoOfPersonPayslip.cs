using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayViewRptSelectNoOfPersonPayslip
    {
        public int? OfficerCount { get; set; }
        public int? SailorCount { get; set; }
        public string BaseCode { get; set; } = null!;
        public string BaseName { get; set; } = null!;
        public string Syscode { get; set; } = null!;
        public string? Area { get; set; }
        public string AreaName { get; set; } = null!;
    }
}
