using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class Sub327List
    {
        public string TransId { get; set; } = null!;
        public int OrderId { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public int PayMonth { get; set; }
        public int? _605606 { get; set; }
        public int? _605a606a { get; set; }
        public int? _610611 { get; set; }
        public int? _612613 { get; set; }
        public int? _615614 { get; set; }
        public int? _690 { get; set; }
        public int? _686687 { get; set; }
        public int? _688689 { get; set; }
        public int? _598 { get; set; }
        public int? _596 { get; set; }
        public int? _600 { get; set; }
        public int? _630 { get; set; }
        public int? _619 { get; set; }
        public string? ItemCat { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Amount { get; set; }

        public virtual Sub327adjustmentTran Trans { get; set; } = null!;
    }
}
