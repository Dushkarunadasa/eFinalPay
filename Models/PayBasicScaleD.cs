using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class PayBasicScaleD
    {
        public int ScaleCode { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int? Sequence { get; set; }
        public string? InsertedBy { get; set; }
        public DateTime InsertOn { get; set; }
        public bool Active { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
    }
}
