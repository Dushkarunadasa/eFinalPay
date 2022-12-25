using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchBankAccount
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string AccCat { get; set; } = null!;
        public string DepnId { get; set; } = null!;
        public string Accno { get; set; } = null!;
    }
}
