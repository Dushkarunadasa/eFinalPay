using FinaPay.Contract;
using FinaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace FinaPay.Services
{
    public class BaseRecovery : IBaseRecovery
    {
        private readonly PaySubjectsContext _db;
        private readonly ILoginDetails _ILog;
        private IHttpContextAccessor _accessor;


        public BaseRecovery(PaySubjectsContext context, ILoginDetails iLog, IHttpContextAccessor sss)
        {
            _accessor = sss;
            _db = context;
            _ILog = iLog;
            _ILog.UpdateUserDetail(_accessor.HttpContext.Request.Cookies["SysCode"], _accessor.HttpContext.Request.Cookies["CatCode"], _accessor.HttpContext.Request.Cookies["officialNo"], _accessor.HttpContext.Request.Cookies["UserName"], _accessor.HttpContext.Request.Cookies["baseCode"], Convert.ToInt32(_accessor.HttpContext.Request.Cookies["UnitID"].ToString()), _accessor.HttpContext.Request.Cookies["UserRoll"]);

        }


        async Task<IEnumerable<SubFinalPayHeadDetail>> IBaseRecovery.GetPendingTransactions(string BaseCode)
        {

            string userRole = _ILog.GetUserRoll();
            Boolean SubjectClerk = false;
            Boolean Secretary = false;
            Boolean CO = false;

            if (userRole == "2")
            {
                SubjectClerk = true;
            }
            else if (userRole == "3")
            {
                SubjectClerk = true;
                Secretary = true;
            }

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.SubjectClerk == SubjectClerk && D.Secreatry == Secretary && D.AuthorizedOfficer == CO && D.Ulevel == 1 && D.UnitId == 4 && H.BaseCode == BaseCode
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
                                                                     Remarks = H.RejectedReason,
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


        async Task<IEnumerable<SubFinalPay327List>> IBaseRecovery.GetEnteredRecovertList(int? TransId)
        {
            return await _db.SubFinalPay327Lists.OrderBy(s => s.OrderId).Where(s => s.TransId == TransId.ToString()).ToListAsync();
        }




        public int GetOrderID(int TransID)
        {
            int returnNo = 1;

            int? OrderId = _db.SubFinalPay327Lists.Where(s => s.TransId == TransID.ToString()).Max(u => (int?)u.OrderId);
            if (OrderId == null)
                returnNo = 1;
            else
                returnNo = OrderId.Value + 1;

            return returnNo;
        }

        async Task<string> IBaseRecovery.UpdateFinalPay327ItemList(SubFinalPay327List obj)
        {
            var Recordlist = await (_db.SubFinalPay327Lists.Where(s => s.TransId == obj.TransId && s.OrderId == obj.OrderId)).ToListAsync();
            if (Recordlist.Count > 0)
            {
                _db.SubFinalPay327Lists.Update(obj);
                await _db.SaveChangesAsync();
                return "Successfully updated";
            }
            else
            {
                _db.SubFinalPay327Lists.Add(obj);
                await _db.SaveChangesAsync();
                return "Successfully Inserted";

            }

        }



        async Task<IEnumerable<SubFinalPay327List>> IBaseRecovery.Delete327Recovery(string TransId, int OrderId)
        {
            SubFinalPay327List ItemList = await _db.SubFinalPay327Lists.Where(s => s.TransId == TransId && s.OrderId == OrderId).SingleOrDefaultAsync();
            if (ItemList != null)
            {

                _db.SubFinalPay327Lists.Remove(ItemList);
                _db.SaveChanges();
            }

            return await _db.SubFinalPay327Lists.OrderBy(s => s.OrderId).Where(s => s.TransId == TransId.ToString()).ToListAsync();
        }

        public async Task<string> Forward327Recovery(int TransId, int UnitId, int Ulevel)
        {
            string userRole = _ILog.GetUserRoll();
            string msg = string.Empty;

            if (Ulevel == 1)
            {
                try
                {
                    int tr = TransId;
                    SubFinalPayDetail ItemList = await (_db.SubFinalPayDetails.Where(S => S.TransId == TransId && S.UnitId == UnitId && S.Ulevel == Ulevel)).SingleAsync();

                    if (ItemList != null)
                    {
                        if (userRole == "1")
                            ItemList.SubjectClerk = true;
                        else if (userRole == "2")
                            ItemList.Secreatry = true;
                        else if (userRole == "3")
                            ItemList.AuthorizedOfficer = true;
                        _db.SubFinalPayDetails.Update(ItemList);
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
            }

            return msg;
        }
        public async Task<string> Reject327ByDDN(int TransId, int UnitId, int Ulevel)
        {
            string userRole = _ILog.GetUserRoll();
            string msg = string.Empty;


            try
            {
                int tr = TransId;
                SubFinalPayDetail ItemList = await (_db.SubFinalPayDetails.Where(S => S.TransId == TransId && S.UnitId == 4 && S.Ulevel == 1)).SingleAsync();

                if (ItemList != null)
                {

                    ItemList.AuthorizedOfficer = false;
                    ItemList.RejectReason = "Rejected by DDN(Pay):Invalid 327 Data found";
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

        public async Task<string> Forward327RecoveryByDDN (int TransId, int UnitId, int Ulevel)
        {
            string userRole = _ILog.GetUserRoll();
            string msg = string.Empty;
            try
            {
                int tr = TransId;
                SubFinalPay327Head  ItemList = await (_db.SubFinalPay327Heads.Where(S => S.TransId == TransId.ToString())).SingleAsync();
                if (ItemList != null)
                {
                    if (userRole == "1")
                        ItemList.Ddnpay = true;
                    else if (userRole == "2")
                        ItemList.Subject = true;
                    else if (userRole == "4")
                        ItemList.AuditStaff = true;
                    else if (userRole == "5")
                        ItemList.AuditOfficer = true;
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }


            return msg;
        }

        async Task<IEnumerable<SubFinalPayHeadDetail>> IBaseRecovery.Get327Transactions(string BaseCode, bool ActionTaken)
        {
            string userRole = _ILog.GetUserRoll();
            //Boolean SubjectClerk = false;
            //Boolean Secretary = false;
            //Boolean CO = false;

            //if (userRole == "2")
            //{
            //    SubjectClerk = ActionTaken;
            //}
            //else if (userRole == "3")
            //{
            //    SubjectClerk = true;
            //    Secretary = true;
            //}

            IEnumerable<SubFinalPayHeadDetail> AllTrans = await (from H in _db.SubFinalPayHeadDetails
                                                                 join D in _db.SubFinalPayDetails on H.TransId equals D.TransId
                                                                 join K in _db.SubFinalPayDischargeTypes on H.Type equals K.Type
                                                                 where D.AuthorizedOfficer == ActionTaken && D.Ulevel == 1 && D.UnitId == 4 && H.BaseCode == BaseCode
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
    }
}
