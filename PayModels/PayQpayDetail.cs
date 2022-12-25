using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayQpayDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string QpayCode { get; set; } = null!;
        public DateTime QpayApDate { get; set; }
        public int? UserId { get; set; }
        public byte[]? Trorder { get; set; }

        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
        public virtual PayQpay QpayCodeNavigation { get; set; } = null!;
    }
}
