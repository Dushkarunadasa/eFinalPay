using FinaPay.Contract;
using FinaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace FinaPay.Services
{
    public class MainServices : IMainServices
    {
        private readonly PaySubjectsContext _db;
        public MainServices(PaySubjectsContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetAllClients()
        {

            IEnumerable<SubFinalPayHeadDetail> Clients = await _db.SubFinalPayHeadDetails.Select(s => s).ToListAsync();
            return Clients;
        }

        public int GetTransID()
        {
            int TransId = _db.SubFinalPayHeadDetails.Select(s => s).Max(x => (int?)x.TransId) ?? 0;
            return TransId;
        }
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetExistingTransDetails(string SysCode, string CatCode, string OfficialNo)
        {
            IEnumerable<SubFinalPayHeadDetail> ExistingTran = await _db.SubFinalPayHeadDetails.Where(s => s.SysCode == SysCode && s.CatCode == CatCode && s.OfficialNo == OfficialNo && s.ActionComplete == false).ToListAsync();
            return ExistingTran;
        }

        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetAllTrans()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                            join k in _db.SubFinalPayDischargeTypes on H.Type equals k.Type                                                            
                                                                select new SubFinalPayHeadDetail
                                                                {
                                                                    TransId = H.TransId,
                                                                    SysCode = H.SysCode,
                                                                    CatCode = H.CatCode,
                                                                    OfficialNo = H.OfficialNo,
                                                                    Type = k.Des,
                                                                    NgReference = H.NgReference,
                                                                    DischargeDt = H.DischargeDt,
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
                                                                }    ).ToListAsync();


            return AllTrans;
        }
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransUnit(int UnitId)
        {

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails   on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.SubjectClerk == false && D.Ulevel == 1 && D.UnitId == UnitId
                                                                 select new SubFinalPayHeadDetail
                                                                 {
                                                                     TransId = H.TransId,
                                                                     SysCode = H.SysCode,
                                                                     CatCode = H.CatCode,
                                                                     OfficialNo = H.OfficialNo,
                                                                     Type = K.Des,
                                                                     NgReference = H.NgReference,
                                                                     DischargeDt = H.DischargeDt,
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
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetActionTakenTrans(int UnitId)
        {

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.AuthorizedOfficer == true && D.Ulevel == 1 && D.UnitId == UnitId
                                                                 select new SubFinalPayHeadDetail
                                                                 {
                                                                     TransId = H.TransId,
                                                                     SysCode = H.SysCode,
                                                                     CatCode = H.CatCode,
                                                                     OfficialNo = H.OfficialNo,
                                                                     Type = K.Des,
                                                                     NgReference = H.NgReference,
                                                                     DischargeDt = H.DischargeDt,
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
                                                                     Remarks = "Amount = " + (_db.SubFinalPayItemLists.Where(s => s.TransId == H.TransId && s.UnitId == UnitId).Sum(S => S.Amount)).ToString(),
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
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetActionPendingTrans(int UnitId)
        {

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.AuthorizedOfficer == false && D.Ulevel == 1 && D.UnitId == UnitId
                                                                 select new SubFinalPayHeadDetail
                                                                 {
                                                                     TransId = H.TransId,
                                                                     SysCode = H.SysCode,
                                                                     CatCode = H.CatCode,
                                                                     OfficialNo = H.OfficialNo,
                                                                     Type = K.Des,
                                                                     NgReference = H.NgReference,
                                                                     DischargeDt = H.DischargeDt,
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
                                                                     Remarks ="Amount = " +(_db.SubFinalPayItemLists.Where(s => s.TransId == H.TransId && s.UnitId == UnitId).Sum(S => S.Amount)).ToString(),
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

        public async Task<string> CreateInitialTransaction(SubInitiateContract obj, int TransId)
        {
            // SubFinalPayHeadDetail dbhead = await _db.SubFinalPayHeadDetails.SingleOrDefaultAsync();
            SubFinalPayHeadDetail dbhead = new SubFinalPayHeadDetail();
            dbhead.TransId = TransId;
            dbhead.SysCode = obj.SysCode.ToString();
            dbhead.CatCode = obj.CatCode.ToString();
            dbhead.OfficialNo = obj.OfficialNo;
            dbhead.Type = obj.Type;
            dbhead.DischargeDt = obj.DischargeDt;
            dbhead.NgReference = obj.NgReference;
            dbhead.BaseCode = obj.BaseCode;
            _db.SubFinalPayHeadDetails.Add(dbhead);
            await _db.SaveChangesAsync();



            SubFinalPayDetail ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 2;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();  //--DNP

            //ActionList = new SubFinalPayDetail();
            //ActionList.TransId = TransId;
            //ActionList.UnitId = 2;
            //ActionList.SubjectClerk = false;
            //ActionList.Secreatry = false;
            //ActionList.AuthorizedOfficer = false;
            //ActionList.Ulevel = 1;
            //_db.SubFinalPayDetails.Add(ActionList);
            //_db.SaveChanges();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 3;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 4;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 8;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 12;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 13;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 14;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 15;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 16;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 17;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 16;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 2;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();

            return "Success";
        }

      









        public async  Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecSec(int UnitId)
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await(from H in _db.SubFinalPayHeadDetails
                                                                join D in _db.SubFinalPayDetails                                                                
                                                                on H.TransId equals D.TransId
                                                                join k in _db.SubFinalPayDischargeTypes on H.Type equals k.Type
                                                                where D.SubjectClerk == true && D.Secreatry==false && D.Ulevel == 1 && D.UnitId == UnitId
                                                                select new SubFinalPayHeadDetail {TransId=H.TransId, SysCode=H.SysCode, CatCode=H.CatCode,OfficialNo = H.OfficialNo,
                                                                    Type=k.Des,NgReference = H.NgReference,DischargeDt = H.DischargeDt,PForm = H.PForm,PFormPath = H.PFormPath,
                                                                    BankCode = H.BankCode,BranchCode = H.BranchCode,AccountNo = H.AccountNo,VoucherNo = H.VoucherNo,VoucherDes = H.VoucherDes,ChequeNo = H.ChequeNo,ChequeDt = H.ChequeDt,
                                                                PaymentDt = H.PaymentDt,ActionComplete = H.ActionComplete,Remarks = H.Remarks,Ddnpay = H.Ddnpay,PaySubClerk = H.PaySubClerk,PaySsailor = H.PaySsailor,AuditSubClerk = H.AuditSubClerk ,AuditSsailor = H.AuditSsailor ,AuditOfficer = H.AuditOfficer ,Ssopay = H.Ssopay,PenSailor = H.PenSailor,PenSsailor = H.PenSsailor,Reject = H.Reject,RejectedReason = H.RejectedReason,RejectedBy = H.RejectedBy,RejectedOn = H.RejectedOn
                                                                }    ).ToListAsync();
            return AllTrans;
        }


        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecAuth(int UnitId)
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails
                                                                 on H.TransId equals D.TransId
                                                                 where D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer==false && D.Ulevel == 1 && D.UnitId == UnitId
                                                                 select H).ToListAsync();
            return AllTrans;
        }
    }
}
