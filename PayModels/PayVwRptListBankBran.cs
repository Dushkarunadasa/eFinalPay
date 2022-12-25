using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListBankBran
    {
        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BranCode { get; set; } = null!;
        public string BranName { get; set; } = null!;
    }
}
