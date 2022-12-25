using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchPerInfoPensionRevice
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public int? OfficerCode { get; set; }
        public string PensionType { get; set; } = null!;
    }
}
