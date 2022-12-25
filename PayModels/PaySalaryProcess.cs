using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PaySalaryProcess
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Units { get; set; }
        public string? BaseCode { get; set; }
        public string? SubUnitCode { get; set; }
        public string? Area { get; set; }
        public int? UserId { get; set; }
        public byte[]? Torder { get; set; }

        public virtual PayItem ItemC { get; set; } = null!;
        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
    }
}
