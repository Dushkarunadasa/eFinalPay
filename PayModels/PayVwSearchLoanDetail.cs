using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchLoanDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string Itemcode { get; set; } = null!;
        public decimal? LoanAmount { get; set; }
        public DateTime? Loandate { get; set; }
        public string? Fullname { get; set; }
    }
}
