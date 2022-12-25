using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class Sub327Action
    {
        public string TransId { get; set; } = null!;
        public string? Remarks { get; set; }
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficialNo { get; set; }
        public DateTime ActionOn { get; set; }
    }
}
