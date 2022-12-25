using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAllowancesTransDetailsHistory1
    {
        public string TransId { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public bool Edit { get; set; }
        public int Amount { get; set; }
        public string? Remarks { get; set; }
        public bool Reject { get; set; }
        public string? EditedBy { get; set; }
    }
}
