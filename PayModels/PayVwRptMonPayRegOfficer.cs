using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonPayRegOfficer
    {
        public int? RowId { get; set; }
        public string? OfficerCode { get; set; }
        public string? OfficerName { get; set; }
        public string? ItemAltName { get; set; }
        public decimal? Amount { get; set; }
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
    }
}
