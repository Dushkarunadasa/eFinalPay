namespace FinaPay.Services
{
    public class LoginDetails:ILoginDetails
    {

        

        private  string  UserName { get; set; }
        private  string UserRoll { get; set; }
        private  int UnitID { get; set; }

        private  string SysCode { get; set; }

        private  string Catcode { get; set; }

        private  string OfficialNo { get; set; }

        private  string BaseCode { get; set; }


        void ILoginDetails.UpdateUserDetail(string sysCode, string catcode, string OfficialNoa, string userName, string baseCode, int unitcode, string userRole)
        {
            SysCode = sysCode;
            Catcode = catcode;
            OfficialNo = OfficialNoa;
            UserName = userName;
            BaseCode = baseCode;
            UnitID =Convert.ToInt32( unitcode);
            UserRoll = userRole;

        }

        public string getUserName()
        {
            return UserName;
        }

        public string getSysCode()
        {
            return SysCode;
        }
        public string getCatcode()
        {
            return Catcode;
        }
        public string getOfficialNo()
        {
            return OfficialNo;
        }
        public string getBaseCode()
        {
            return BaseCode;
        }
        public int getUnitID()
        {
            return UnitID;
        }
        public string GetUserRoll()
        {
            return UserRoll;
        }

      
        
    }
}
