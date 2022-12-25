using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayStatusDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string StatusCode { get; set; } = null!;
        public DateTime DateEffect { get; set; }
        public DateTime? DateRemove { get; set; }
        public string? RemarkEffect { get; set; }
        public string? DtgrefEffect { get; set; }
        public string? RemarkRemove { get; set; }
        public string? DtgrefRemove { get; set; }
        public string? CountryCode { get; set; }
        public string? Reason { get; set; }
        public decimal? PunishDays { get; set; }
        public string? PayMonth { get; set; }
        public byte[]? Trorder { get; set; }
        public int? UserId { get; set; }

        public virtual PayPerInfo PayPerInfo { get; set; } = null!;
        public virtual PayStatus StatusCodeNavigation { get; set; } = null!;
    }
}
