using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubGradeRate
    {
        public string? Grade { get; set; }
        public decimal? Rate { get; set; }
        public string? Type { get; set; }
    }
}
