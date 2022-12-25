using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptComplementList
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string? Rankname { get; set; }
        public string? Initials { get; set; }
        public string? Surname { get; set; }
        public string? Basecode { get; set; }
        public string? Basename { get; set; }
        public string? BranchCode { get; set; }
    }
}
