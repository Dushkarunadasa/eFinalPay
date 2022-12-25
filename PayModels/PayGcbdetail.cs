using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayGcbdetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Gcbcode { get; set; } = null!;
        public DateTime? GcbapDate { get; set; }
        public int? UserId { get; set; }
        public byte[]? Trorder { get; set; }

        public virtual PayGcbtype GcbcodeNavigation { get; set; } = null!;
        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
    }
}
