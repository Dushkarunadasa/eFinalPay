using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.PayModels;
using Microsoft.EntityFrameworkCore;

namespace FinaPay.Services
{
    public class PayDetails : IPayDetails
    {
        private Payroll_SLNavyContext _db;
        private readonly PaySubjectsContext _PaySubdb;
        public PayDetails(Payroll_SLNavyContext db, PaySubjectsContext paySubdb)
        {
            _db = db;
            _PaySubdb = paySubdb;
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
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPayRecoveryPendingList( Boolean Authorized)
        {

            var Details = await _db.PayBases.ToListAsync();
            //string basecode = //Details.Where(s => s.BaseCode == "1018").Select(S => S.BaseName).ToString();
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _PaySubdb.SubFinalPayHeadDetails
                                                                 join k in _PaySubdb.SubFinalPayDischargeTypes on H.Type equals k.Type                                                                
                                                                 select new SubFinalPayHeadDetail
                                                                 {
                                                                     TransId = H.TransId,
                                                                     SysCode = H.SysCode,
                                                                     CatCode = H.CatCode,
                                                                     OfficialNo = H.OfficialNo,
                                                                     Type = k.Des,
                                                                     NgReference = H.NgReference,
                                                                     DischargeDt = H.DischargeDt,
                                                                     BaseCode = H.BaseCode,
                                                                     PForm = H.PForm,
                                                                     PFormPath = H.PFormPath,
                                                                     BankCode = H.BankCode,
                                                                     BranchCode = H.BranchCode,
                                                                     AccountNo = H.AccountNo,
                                                                     VoucherNo = H.VoucherNo,
                                                                     VoucherDes = H.VoucherDes,
                                                                     ChequeNo = H.ChequeNo,
                                                                     ChequeDt = H.ChequeDt,
                                                                     PaymentDt = H.PaymentDt,
                                                                     ActionComplete = H.ActionComplete,
                                                                     Remarks = H.Remarks,
                                                                     Ddnpay = H.Ddnpay,
                                                                     PaySubClerk = H.PaySubClerk,
                                                                     PaySsailor = H.PaySsailor,
                                                                     AuditSubClerk = H.AuditSubClerk,
                                                                     AuditSsailor = H.AuditSsailor,
                                                                     AuditOfficer = H.AuditOfficer,
                                                                     Ssopay = H.Ssopay,
                                                                     PenSailor = H.PenSailor,
                                                                     PenSsailor = H.PenSsailor,
                                                                     Reject = H.Reject,
                                                                     RejectedReason = H.RejectedReason,
                                                                     RejectedBy = H.RejectedBy,
                                                                     RejectedOn = H.RejectedOn
                                                                 }).ToListAsync();


            return AllTrans;
        }
    }
}
