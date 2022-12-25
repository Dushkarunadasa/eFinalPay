using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PenVwPensionReportSinhala
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string PensionType { get; set; } = null!;
        public DateTime? ReEngageDate { get; set; }
        public DateTime? Seniority { get; set; }
        public int RetAgeYear { get; set; }
        public int RetAgeMonth { get; set; }
        public int RetAgeDay { get; set; }
        public string RankCode { get; set; } = null!;
        public string Regulation { get; set; } = null!;
        public DateTime ServiceEndDate { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime LaspPaidDate { get; set; }
        public DateTime PensionStartDate { get; set; }
        public int TotRecServYear { get; set; }
        public int TotRecServMonth { get; set; }
        public int TotRecServDay { get; set; }
        public int TotActServYear { get; set; }
        public int TotActServMonth { get; set; }
        public int TotActServDay { get; set; }
        public decimal ConSalary { get; set; }
        public decimal TotGcb { get; set; }
        public decimal TotQpay { get; set; }
        public decimal TotRationMoney { get; set; }
        public decimal TotReEngage { get; set; }
        public decimal PensionPerc { get; set; }
        public decimal PensionBefore { get; set; }
        public decimal PensionAfter { get; set; }
        public decimal GratuityAmount { get; set; }
        public decimal OtherAmount1 { get; set; }
        public decimal OtherAmount2 { get; set; }
        public decimal ChildCount { get; set; }
        public decimal AmountPerChild { get; set; }
        public string Name { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
    }
}
