namespace FinaPay.Services
{
    public sealed class LoginDetails:ILoginDetails
    {

        

        private static string  UserName { get; set; }
        private static string UserRoll { get; set; }
        private static int UnitID { get; set; }

        private static string SysCode { get; set; }

        private static string Catcode { get; set; }

        private static string OfficialNo { get; set; }

        private static string BaseCode { get; set; }


        void ILoginDetails.UpdateUserDetail(string sysCode, string catcode, string OfficialNo, string userName, string baseCode, int unitcode, string userRole)
        {
            SysCode = sysCode;
            Catcode = catcode;
            OfficialNo = OfficialNo;
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
