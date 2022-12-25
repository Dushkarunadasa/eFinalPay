namespace FinaPay.Contract
{
    public class RecoveryCheckDetailContract
    {
         public int TransID { get; set; }
        public int UnitId { get; set; }
        public string Unit { get; set; }
        public string ItemCode { get; set; }
        public string Item { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }

    }
}
