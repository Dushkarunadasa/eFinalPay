using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemMonthlyTran
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? EffectFrom { get; set; }
        public string? EffectTo { get; set; }
        public int? UserId { get; set; }
        public decimal? Torder { get; set; }
        public DateTime? Trdarte { get; set; }
        public int? NumofIns { get; set; }

        public virtual PayCategory CatCodeNavigation { get; set; } = null!;
        public virtual PayItem ItemC { get; set; } = null!;
        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
    }
}
