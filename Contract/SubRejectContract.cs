using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FinaPay.Contract
{
    public class SubRejectContract

    {
        [Required]
        public int? TransId { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public string RejectReason { get; set; }

    }
}
