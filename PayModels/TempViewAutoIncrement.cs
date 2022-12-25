using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class TempViewAutoIncrement
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public DateTime? AutoIncrementDt { get; set; }
        public string Name { get; set; } = null!;
        public string RankName { get; set; } = null!;
    }
}
