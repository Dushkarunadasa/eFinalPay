using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListSubUnit
    {
        public string Scode { get; set; } = null!;
        public string Sname { get; set; } = null!;
        public string Bcode { get; set; } = null!;
        public string Bname { get; set; } = null!;
        public string RiskArea { get; set; } = null!;
        public string Ship { get; set; } = null!;
        public string Active { get; set; } = null!;
    }
}
