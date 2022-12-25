using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayFormMaster
    {
        public int FrmId { get; set; }
        public string? FrmCode { get; set; }
        public string? FrmDesc { get; set; }
        public string? FrmOptions { get; set; }
        public string? FrmType { get; set; }
    }
}
