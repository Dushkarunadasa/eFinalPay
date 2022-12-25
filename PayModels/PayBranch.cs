using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBranch
    {
        public string BranchCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? BranchSname { get; set; }

        public virtual PayCategory CatCodeNavigation { get; set; } = null!;
    }
}
