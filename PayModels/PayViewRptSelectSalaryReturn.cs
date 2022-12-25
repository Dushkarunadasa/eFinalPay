using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayViewRptSelectSalaryReturn
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Initials { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string ReturnMonth { get; set; } = null!;
        public string SalaryMonth { get; set; } = null!;
        public decimal Amount { get; set; }
        public string Basecode { get; set; } = null!;
        public string Basename { get; set; } = null!;
        public int? Trorder { get; set; }
        public string? PayMonth { get; set; }
    }
}
