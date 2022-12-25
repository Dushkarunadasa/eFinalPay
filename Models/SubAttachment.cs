using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAttachment
    {
        public string? TransId { get; set; }
        public int? Torder { get; set; }
        public string? Tattachment { get; set; }
        public string? Tpath { get; set; }
    }
}
