using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayArea
    {
        public PayArea()
        {
            PayBases = new HashSet<PayBase>();
        }

        public string AreaCode { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string? AreaStName { get; set; }
        public string? AreaEmail { get; set; }

        public virtual ICollection<PayBase> PayBases { get; set; }
    }
}
