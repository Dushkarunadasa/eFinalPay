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
        private readonly PayModels.Payroll_SLNavyContext _PayDb;
        public MainServices(PaySubjectsContext db, PayModels.Payroll_SLNavyContext Paydb)
        {
            _db = db;
            _PayDb = Paydb;
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

        public async Task<IEnumerable<SubFinalPayHeadDetail>> LoadExistingTransDetail(int TransId)
        {
            IEnumerable<SubFinalPayHeadDetail> ExistingTran = await _db.SubFinalPayHeadDetails.Where(s => s.TransId == TransId && s.ActionComplete == false).ToListAsync();
            return ExistingTran;
        }


     
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetAllTrans(int UnitId,Boolean Authorized)
        {

            var Details = await _PayDb.PayBases.ToListAsync();
            //string basecode = //Details.Where(s => s.BaseCode == "1018").Select(S => S.BaseName).ToString();
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join k in _db.SubFinalPayDischargeTypes on H.Type equals k.Type
                                                                 where H.Unit == UnitId && H.Authorized == Authorized
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
        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransUnit(int UnitId)
        {

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.SubjectClerk == false && D.Ulevel == 1 && D.UnitId == UnitId && H.Authorized == true
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
                                                                 where D.AuthorizedOfficer == false && D.Ulevel == 1 && D.UnitId == UnitId && H.Authorized == true
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
        public async Task<string> CreateInitialTransaction(SubInitiateContract obj, int TransId, int UnitId)
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
            dbhead.SubjectClerk = true;
            dbhead.Authorized = false;
            dbhead.Unit = UnitId;
            _db.SubFinalPayHeadDetails.Add(dbhead);
            await _db.SaveChangesAsync();



            //SubFinalPayDetail ActionList = new SubFinalPayDetail();
            //ActionList.TransId = TransId;
            //ActionList.UnitId = 2;
            //ActionList.SubjectClerk = false;
            //ActionList.Secreatry = false;
            //ActionList.AuthorizedOfficer = false;
            //ActionList.Ulevel = 1;
            //_db.SubFinalPayDetails.Add(ActionList);
            //await _db.SaveChangesAsync();  //DNT// Add two staff officers as per the request of DNP Unit 23 24





            SubFinalPayDetail ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 4;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//BaseShip

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 26;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//DNI change to SIO(Ground)

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 12;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//DNVC

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 13;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//Director Sport

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 14;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//DD(L&A)

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 15;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//DNB

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 16;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//SSO(SM) Recovery



            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 16;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 2;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//SSO(SM) All Recovery

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 17;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//DNA

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 23;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//SSO(Foreign)

            ActionList = new SubFinalPayDetail();
            ActionList.TransId = TransId;
            ActionList.UnitId = 24;
            ActionList.SubjectClerk = false;
            ActionList.Secreatry = false;
            ActionList.AuthorizedOfficer = false;
            ActionList.Ulevel = 1;
            _db.SubFinalPayDetails.Add(ActionList);
            await _db.SaveChangesAsync();//SSO(Local)

            SubFinalPay327Head HeadTable = new SubFinalPay327Head();
            HeadTable.TransId = TransId.ToString();
            HeadTable.UnitId = 4;
            HeadTable.BaseCode = obj.BaseCode;
            _db.SubFinalPay327Heads.Add(HeadTable);
            await _db.SaveChangesAsync();//327 Head Table

            return "Success";
        }



        public async Task<string> UpdateProfile(ProfileUpdateBasicContract obj, int TransId)
        {


            var dbhead = await _db.SubFinalPayHeadDetails.FirstOrDefaultAsync(S => S.TransId == TransId);

            dbhead.Type = obj.Type;
            dbhead.DischargeDt = obj.DischargeDt;
            dbhead.NgReference = obj.NgReference;
            dbhead.BaseCode = obj.BaseCode;
            _db.SubFinalPayHeadDetails.Update(dbhead);
            await _db.SaveChangesAsync();


            SubFinalPay327Head HeadTable = new SubFinalPay327Head();
            HeadTable.TransId = TransId.ToString();
            HeadTable.UnitId = 4;
            HeadTable.BaseCode = obj.BaseCode;
            _db.SubFinalPay327Heads.Update(HeadTable);
            await _db.SaveChangesAsync();

            return "Success";
        }



        public async Task<string> ApproveProfile(int TransId)
        {
            var dbhead = await _db.SubFinalPayHeadDetails.FirstOrDefaultAsync(S => S.TransId == TransId);
            dbhead.Authorized = true;
            _db.SubFinalPayHeadDetails.Update(dbhead);
            await _db.SaveChangesAsync();

            return "Approved";
        }




        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecSec(int UnitId)
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails
                                                                 on H.TransId equals D.TransId
                                                                 join k in _db.SubFinalPayDischargeTypes on H.Type equals k.Type
                                                                 where D.SubjectClerk == true && D.Secreatry == false && D.Ulevel == 1 && D.UnitId == UnitId
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
                                                                 }).ToListAsync();
            return AllTrans;
        }


        public async Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecAuth(int UnitId)
        {
            //IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
            //                                                     join D in _db.SubFinalPayDetails
            //                                                     on H.TransId equals D.TransId
            //                                                     where D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer==false && D.Ulevel == 1 && D.UnitId == UnitId
            //                                                     select H).ToListAsync();


            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails
                                                                 on H.TransId equals D.TransId
                                                                 join k in _db.SubFinalPayDischargeTypes on H.Type equals k.Type
                                                                 where D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer == false && D.Ulevel == 1 && D.UnitId == UnitId
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
                                                                 }).ToListAsync();


            return AllTrans;
        }
    }
}
