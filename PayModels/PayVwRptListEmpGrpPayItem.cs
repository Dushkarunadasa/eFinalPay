using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListEmpGrpPayItem
    {
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string ItemName { get; set; } = null!;
    }
}
