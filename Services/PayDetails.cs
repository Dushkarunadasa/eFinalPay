using FinaPay.Contract;
using FinaPay.PayModels;
using Microsoft.EntityFrameworkCore;

namespace FinaPay.Services
{
    public class PayDetails : IPayDetails
    {
        private Payroll_SLNavyContext _db;

        public PayDetails(Payroll_SLNavyContext db)
        {
            _db = db;
        }
        IEnumerable<PayBase> IPayDetails.GetBaseList()
        {
            IEnumerable<PayBase> BaseList = _db.PayBases.OrderBy(s=>s.BaseName).Select(s => s).ToList();
            return BaseList;
        }

        IEnumerable<PayBank> IPayDetails.GetBankList(string SysCode, string CatCode, string OfficialNo)
        {
            //return _db.PayBanks.OrderBy(s => s.BankName).Select(s => s).ToList();


            return from D in _db.PayBankAccs
                   join E in _db.PayBanks on D.BankCode equals E.BankCode
                   where D.SysCode == SysCode && D.CatCode == CatCode && D.OfficerCode == OfficialNo && D.Active == true
                   select  E ;

        }

        IEnumerable<PayBankBranch> IPayDetails.GetBranchList(string BankCode, string SysCode, String CatCode, String OfficialNo)
        {
            return from D in _db.PayBankAccs
                   join E in _db.PayBankBranches on
                   new { BankCode = D.BankCode, BranchCode = D.BranchCode } equals new { BankCode = E.BankCode, BranchCode = E.BranchCode }
                   where D.SysCode==SysCode && D.CatCode==CatCode && D.OfficerCode==OfficialNo && D.BankCode==BankCode
                   orderby E.BranchName
                   select E ;

            //return _db.PayBankBranches.OrderBy(s => s.BranchName).Where(s => s.BankCode == BankCode && s.sy).ToList();
        }

        IEnumerable<PayBankAcc> IPayDetails.GetAccountList(string SysCode, string CatCode, string OfficialNo, string BankCode, string BranchCode)
        {
            return _db.PayBankAccs.Where(s => s.SysCode == SysCode && s.CatCode == CatCode && s.OfficerCode == OfficialNo && s.BankCode == BankCode && s.BranchCode == BranchCode && s.Active == true).ToList();
        }
        IEnumerable<PayPerInfo> IPayDetails.GetPerInfo(string SysCode, string CatCode, string OfficialNo)
        {
            return _db.PayPerInfos.Where(s => s.SysCode == SysCode && s.CatCode == CatCode && s.OfficerCode == OfficialNo).ToList();
        }
        public async Task<string> GetPerInfoBaseCode(string SysCode, string CatCode, string OfficialNo)
        {
            var t1= _db.PayPerInfos.Where(s => s.SysCode == SysCode && s.CatCode == CatCode && s.OfficerCode == OfficialNo).Select(S => S.BaseCode).FirstOrDefaultAsync();
           
            return t1.Result.ToString();
        }
    }
}
