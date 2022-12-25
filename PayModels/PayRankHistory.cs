using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayRankHistory
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public DateTime DateEffect { get; set; }
        public bool Active { get; set; }
        public byte[]? Picture { get; set; }
        public bool ArearsPaid { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public bool? ConfirmAreasPaid { get; set; }
        public int RankStage { get; set; }
        public decimal TrNo { get; set; }
        public string RankGroup { get; set; } = null!;
        public int? UserId { get; set; }
        public string? Referance { get; set; }
    }
}
