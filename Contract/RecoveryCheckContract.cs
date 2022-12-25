namespace FinaPay.Contract
{
    public class RecoveryCheckContract
    {
        public int TransID { get; set; }

        public string SysCode { get; set; }

        public string CatCode { get; set; }

        public string OfficialNo { get; set; }

        public string Type { get; set; }

        public DateTime DischargeDt { get; set; }

        public string Pending { get; set; }

        public decimal Amount { get; set; }

        public bool IsPending { get; set; }
    }
}
