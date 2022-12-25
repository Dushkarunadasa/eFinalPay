using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SystemFreeze
    {
        public bool Freeze { get; set; }
        public DateTime UpdateOn { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
    }
}
