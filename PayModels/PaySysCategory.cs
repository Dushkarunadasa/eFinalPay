using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PaySysCategory
    {
        public string SysCode { get; set; } = null!;
        public string SysCatName { get; set; } = null!;
        public string? SysType { get; set; }

        public virtual PaySysSetup? PaySysSetup { get; set; }
    }
}
