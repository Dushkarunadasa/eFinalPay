using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAllowancesTransDetail
    {
        public string TransId { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public DateTime EffectDate { get; set; }
        public bool Edit { get; set; }
        public decimal Amount { get; set; }
        public string? ArrearsCode { get; set; }
        public decimal? ArrearsAmount { get; set; }
        public string? OverPayCode { get; set; }
        public decimal? OverPayAmount { get; set; }
        public string? Remarks { get; set; }
        public bool Reject { get; set; }
        public string? EditedBy { get; set; }
    }
}
