using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListDisHardRationOfficer
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string BaseName { get; set; } = null!;
        public string? C601 { get; set; }
        public decimal? U601 { get; set; }
        public decimal? A601 { get; set; }
        public string? C602 { get; set; }
        public decimal? U602 { get; set; }
        public decimal? A602 { get; set; }
        public string? C603 { get; set; }
        public decimal? U603 { get; set; }
        public decimal? A603 { get; set; }
        public string? C604 { get; set; }
        public decimal? U604 { get; set; }
        public decimal? A604 { get; set; }
        public string Name { get; set; } = null!;
    }
}
