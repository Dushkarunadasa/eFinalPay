using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptDibankloanAccount
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string Mname { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public string Bankcode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BarnchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? Accno { get; set; }
        public decimal? AmtToSend { get; set; }
        public string? DepnId { get; set; }
        public string Dmane { get; set; } = null!;
    }
}
