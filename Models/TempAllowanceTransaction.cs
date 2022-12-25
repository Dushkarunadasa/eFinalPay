using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class TempAllowanceTransaction
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficialNo { get; set; }
        public DateTime? EffectDt { get; set; }
    }
}
