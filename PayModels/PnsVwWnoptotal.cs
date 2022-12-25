using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PnsVwWnoptotal
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string? Zyear { get; set; }
        public decimal? Amount { get; set; }
    }
}
