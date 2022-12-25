using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListCategory
    {
        public string Code { get; set; } = null!;
        public string Descr { get; set; } = null!;
        public decimal SalDisAmnt { get; set; }
    }
}
