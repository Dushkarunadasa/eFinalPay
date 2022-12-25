using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBase
    {
        public PayBase()
        {
            PayBaseSubUnits = new HashSet<PayBaseSubUnit>();
            PayItemBases = new HashSet<PayItemBase>();
        }

        public string BaseCode { get; set; } = null!;
        public string BaseName { get; set; } = null!;
        public string AreaCode { get; set; } = null!;
        public bool RiskArea { get; set; }
        public bool ArtiArea { get; set; }
        public bool Ship { get; set; }
        public bool Active { get; set; }
        public string? BaseNameSin { get; set; }
        public string? BaseSname { get; set; }
        public string? BaseEmail { get; set; }

        public virtual PayArea AreaCodeNavigation { get; set; } = null!;
        public virtual ICollection<PayBaseSubUnit> PayBaseSubUnits { get; set; }
        public virtual ICollection<PayItemBase> PayItemBases { get; set; }
    }
}
