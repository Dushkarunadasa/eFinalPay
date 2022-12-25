using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayProcessMonth
    {
        public string CurMonth { get; set; } = null!;
        public string PrevMonth { get; set; } = null!;
    }
}
