using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPayLogDetail
    {
        public int TransId { get; set; }
        public int UnitId { get; set; }
        public string UserId { get; set; } = null!;
        public string? LogDetails { get; set; }
        public DateTime Logtime { get; set; }
        public string? Ip { get; set; }
    }
}
