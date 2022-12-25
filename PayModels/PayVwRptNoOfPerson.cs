using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptNoOfPerson
    {
        public string SysCode { get; set; } = null!;
        public string SysCatName { get; set; } = null!;
        public string CatDesc { get; set; } = null!;
        public int? HeadCount { get; set; }
    }
}
