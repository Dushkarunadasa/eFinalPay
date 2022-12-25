using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListCalander
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal? C735 { get; set; }
        public decimal? C763 { get; set; }
        public decimal? C841 { get; set; }
        public decimal? C872 { get; set; }
        public decimal? C884 { get; set; }
        public decimal? C963 { get; set; }
        public decimal? C735A { get; set; }
        public decimal? C963A { get; set; }
        public string BaseName { get; set; } = null!;
        public string Basecode { get; set; } = null!;
    }
}
