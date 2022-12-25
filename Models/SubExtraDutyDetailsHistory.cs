using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubExtraDutyDetailsHistory
    {
        public string TransId { get; set; } = null!;
        public DateTime EffectDt { get; set; }
        public string Sfrom { get; set; } = null!;
        public string? Sto { get; set; }
        public int? Hrs { get; set; }
        public decimal? Minutes { get; set; }
        public string? Details { get; set; }
        public string? Remarks { get; set; }
        public decimal? Amount { get; set; }
    }
}
