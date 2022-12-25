using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListEmpBasicSal
    {
        public string SysCode { get; set; } = null!;
        public string? SysName { get; set; }
        public string CatCode { get; set; } = null!;
        public string? CatName { get; set; }
        public string OfficerCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string? RankName { get; set; }
        public string Name { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public decimal? Bsalary { get; set; }
    }
}
