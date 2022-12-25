namespace FinaPay.Contract
{
    public class SubMainPendingContract
    {
        public int TransID { get; set; }

        public string SysCode { get; set; }

        public string CatCode { get; set; }

        public string OfficialNo { get; set; }

        public string Type { get; set; }
        public DateTime DischargeDt { get; set; }

        public Boolean S_Sailor { get; set; }

        public Boolean S_Sec { get; set; }
        public Boolean A_Officer { get; set; }
    }
}
