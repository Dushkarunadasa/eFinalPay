using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayPerInfoForEmail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
