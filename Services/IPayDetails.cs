using FinaPay.Models;
using FinaPay.PayModels;

namespace FinaPay.Services

{
    public interface IPayDetails
    {
        public IEnumerable<PayBase> GetBaseList();
        public IEnumerable<PayBank> GetBankList(string SysCode, string CatCode, string OfficialNo);
        public IEnumerable<PayBankBranch> GetBranchList(string BankCode, string SysCode, String CatCode, String OfficialNo);
        public IEnumerable<PayBankAcc> GetAccountList(string SysCode,string CatCode,string OfficialNo,string BankCode,string BranchCode);

        public IEnumerable<PayPerInfo> GetPerInfo(string SysCode, string CatCode, string OfficialNo);
        public Task< string>  GetPerInfoBaseCode(string SysCode, string CatCode, string OfficialNo);

        Task <IEnumerable<SubFinalPayHeadDetail>> GetPayRecoveryPendingList(Boolean PendinfFlag);

    }
}
