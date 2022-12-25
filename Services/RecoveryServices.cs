using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.PayModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;

namespace FinaPay.Services
{
    public class RecoveryServices : IRecoveryServices
    {
        private readonly PaySubjectsContext _IRec;
        private readonly ILoginDetails _ILog;

        public RecoveryServices(PaySubjectsContext IRec, ILoginDetails ILog)

        {
            this._IRec = IRec;
            this._ILog = ILog;
        }

        async Task<IEnumerable<SubFinalPayItem>> IRecoveryServices.AllItemsUnitWise(int UnitID)
        {
            return await _IRec.SubFinalPayItems.OrderBy(s => s.ItemCode).Where(s => s.Unit == UnitID).ToListAsync();

        }

        async Task<string> IRecoveryServices.UpdateFinalPayItemList(int TransId, int UnitID, string ItemCode, decimal Amount, string remark)
        {
            var Recordlist = await (_IRec.SubFinalPayItemLists.Where(s => s.TransId == TransId && s.UnitId == UnitID && s.ItemCode == ItemCode.Trim())).ToListAsync();
            if (Recordlist.Count > 0)
            {
                SubFinalPayItemList ItemList = new SubFinalPayItemList();
                ItemList.TransId = TransId;
                ItemList.UnitId = UnitID;
                ItemList.ItemCode = ItemCode;
                ItemList.Amount = Amount;
                ItemList.Remarks = remark;
                _IRec.SubFinalPayItemLists.Update(ItemList);
                await _IRec.SaveChangesAsync();
                return "Successfully updated";
            }
            else
            {
                SubFinalPayItemList ItemList = new SubFinalPayItemList();
                ItemList.TransId = TransId;
                ItemList.UnitId = UnitID;
                ItemList.ItemCode = ItemCode;
                ItemList.Amount = Amount;
                ItemList.Remarks = remark;
                _IRec.SubFinalPayItemLists.Add(ItemList);
                await _IRec.SaveChangesAsync();
                return "Successfully Inserted";

            }

        }

        async Task<IEnumerable<SubPayRecoveryContrat>> IRecoveryServices.GetEnteredRecovertList(int? TransId)
        {


            return await (from I in _IRec.SubFinalPayItemLists
                          join L in _IRec.SubFinalPayItems
                          on new { ItemCode = I.ItemCode, UnitId = I.UnitId } equals
                          new { ItemCode = L.ItemCode, UnitId = L.Unit }
                          where L.Unit == Convert.ToInt16(_ILog.getUnitID()) && I.TransId == TransId
                          select new SubPayRecoveryContrat { TransID = I.TransId, ItemCode = I.ItemCode, ItemName = L.ItemDescription, Amount = Convert.ToDecimal(I.Amount), Remarks = I.Remarks }).ToListAsync();




        }



        async Task<IEnumerable<SubPayRecoveryContrat>> IRecoveryServices.DeleteRecovery(int TransId, string ItemCode)
        {
            SubFinalPayItemList ItemList = await _IRec.SubFinalPayItemLists.Where(s => s.TransId == TransId && s.ItemCode == ItemCode && s.UnitId == _ILog.getUnitID()).SingleOrDefaultAsync();
            if (ItemList != null)
            {

                _IRec.SubFinalPayItemLists.Remove(ItemList);
                _IRec.SaveChanges();
            }

            return await (from I in _IRec.SubFinalPayItemLists
                          join L in _IRec.SubFinalPayItems
                          on new { ItemCode = I.ItemCode, UnitId = I.UnitId } equals
                          new { ItemCode = L.ItemCode, UnitId = L.Unit }
                          where L.Unit == Convert.ToInt16(_ILog.getUnitID()) && I.TransId == TransId
                          select new SubPayRecoveryContrat { TransID = I.TransId, ItemCode = I.ItemCode, ItemName = L.ItemDescription, Amount = Convert.ToDecimal(I.Amount), Remarks = I.Remarks }).ToListAsync();

        }

        public async Task<string> ForwardSubRecovery(int TransId, int UnitId, int Ulevel)
        {
            string userRole = _ILog.GetUserRoll();
            string msg = string.Empty;

            if (Ulevel != 4)
            {
                try
                {
                    int tr = TransId;
                    SubFinalPayDetail ItemList = await (_IRec.SubFinalPayDetails.Where(S => S.TransId == TransId && S.UnitId == UnitId && S.Ulevel == Ulevel)).SingleAsync();

                    if (ItemList != null)
                    {
                        if (userRole == "1")
                            ItemList.SubjectClerk = true;
                        else if (userRole == "2")
                            ItemList.Secreatry = true;
                        else if (userRole == "3")
                            ItemList.AuthorizedOfficer = true;
                        _IRec.SubFinalPayDetails.Update(ItemList);
                        _IRec.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
            }
            else
            {
                if (userRole == "1")
                {
                    _IRec.SubFinalPayHeadDetails.Where(S => S.TransId == TransId).ToList().ForEach(a => { a.Ddnpay = true; });
                    _IRec.SaveChanges();
                }

            }
            return msg;
        }




        public async Task updateLog(SubFinalPayLogDetail lg)
        {
            await _IRec.SubFinalPayLogDetails.AddAsync(lg);
            await _IRec.SaveChangesAsync();
        }


        public async Task<IEnumerable<RecoveryCheckDetailContract>> GetReceiveRecDetails(int TransId)
        {

            return await (from L in _IRec.SubFinalPayItemLists
                          join I in _IRec.SubFinalPayItems on new { ItemCode = L.ItemCode, UnitId = L.UnitId } equals new { ItemCode = I.ItemCode, UnitId = I.Unit }
                          join U in _IRec.SubAllowancesSubjects on I.Unit equals U.SubId

                          join D in _IRec.SubFinalPayDetails
                          on new { TransId = L.TransId, UnitId = L.UnitId } equals new { TransId = D.TransId, UnitId = D.UnitId }
                          orderby U.Subject
                          where L.TransId == TransId && D.AuthorizedOfficer == true && D.Reject == false && D.Ulevel == 1 && D.TransId == TransId

                          select (new RecoveryCheckDetailContract { TransID = L.TransId, UnitId = L.UnitId, Unit = U.Subject, ItemCode = L.ItemCode, Item = I.ItemDescription, Amount = Convert.ToDecimal(L.Amount), Remarks = L.Remarks })).Distinct().ToListAsync();



        }

        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecAuth(int UnitId, string RollId, int uLevel)
        {

            var PendingList = new List<Test1>();
            decimal total = 0;
            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer == false && D.Ulevel == uLevel

                     orderby H.TransId
                     select new { H.TransId, g.Subject };




            string details = string.Empty;

            foreach (var item in tg)
            {


                total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == item.TransId select h.Amount).Sum());
                PendingList.Add(new Test1 { TransId = item.TransId, PendingList = details, pending = false, Amount = total });

                details = item.Subject.Trim();

            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId

                                where D.UnitId == UnitId && D.Ulevel == 2 && D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer == false

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = H.Type,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }
        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecDDN(int UnitId, string RollId, int uLevel)
        {

            var PendingList = new List<Test1>();
            decimal total = 0;
            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer == true && D.Ulevel == 2 && H.Ddnpay == false

                     orderby H.TransId
                     select new { H.TransId, g.Subject };




            string details = string.Empty;

            foreach (var item in tg)
            {


                total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == item.TransId select h.Amount).Sum());
                PendingList.Add(new Test1 { TransId = item.TransId, PendingList = details, pending = false, Amount = total });

                details = item.Subject.Trim();

            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                                join K in _IRec.SubFinalPayDischargeTypes on Convert.ToString(H.Type) equals K.Type
                                where D.Ulevel == 2 && D.SubjectClerk == true && D.Secreatry == true && D.AuthorizedOfficer == true && H.Ddnpay == false

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }


        public async Task<IEnumerable<RecoveryCheckContract>> GetForwardedRecDDN(int UnitId, string RollId, int uLevel)
        {

            var PendingList = new List<Test1>();
            decimal total = 0;
            var tg = from H in _IRec.SubFinalPayHeadDetails
                   
                     where  H.Ddnpay == true

                     orderby H.TransId
                     select new { H.TransId, Subject= "" };




            string details = string.Empty;

            foreach (var item in tg)
            {


                total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == item.TransId select h.Amount).Sum());
                PendingList.Add(new Test1 { TransId = item.TransId, PendingList = details, pending = false, Amount = total });

                details = item.Subject.Trim();

            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails                              
                                join K in _IRec.SubFinalPayDischargeTypes on Convert.ToString(H.Type) equals K.Type
                                where  H.Ddnpay == true

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }
        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecSec(int UnitId, string RollId)
        {

            var PendingList = new List<Test1>();
            decimal total = 0;

            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.SubjectClerk == true && D.Secreatry == false && D.Ulevel == 2

                     orderby H.TransId
                     select new { H.TransId, g.Subject };



            string details = string.Empty;

            foreach (var item in tg)
            {


                total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == item.TransId select h.Amount).Sum());
                PendingList.Add(new Test1 { TransId = item.TransId, PendingList = details, pending = false, Amount = total });

                details = item.Subject.Trim();

            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                                join K in _IRec.SubFinalPayDischargeTypes on H.Type equals K.Type
                                where D.UnitId == UnitId && D.Ulevel == 2 && D.SubjectClerk == true && D.Secreatry == false

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }

    
        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedActionPending(int UnitId, string RollId)
        {
            var list = new List<int>() { 3, 4, 5, 6, 7 };

            var PendingList = new List<Test1>();
            decimal total = 0;

            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.AuthorizedOfficer == false && D.Ulevel == 1
                     && !list.Contains(D.UnitId)
                     orderby H.TransId
                     select new { H.TransId, g.Subject };

            int transid;
            int transid2 = 0;
            string details = string.Empty;

            int count = tg.Count();
            int temp = 0;

            foreach (var item in tg)
            {
                temp++;
                transid = item.TransId;
                if (transid2 == 0)
                {
                    transid2 = transid;

                }
                if (transid2 == transid)
                {
                    if (details.Length > 0)
                    {

                        details = details + "," + item.Subject.Trim();
                    }
                    else
                    {


                        details = item.Subject.Trim();
                    }
                    if (count == temp)
                    {
                        total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                        PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                        transid2 = transid;
                        details = item.Subject.Trim();

                    }
                }

                else
                {
                    total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                    PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                    transid2 = transid;
                    details = item.Subject.Trim();
                }
            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                                join K in _IRec.SubFinalPayDischargeTypes on H.Type equals K.Type
                                where D.UnitId == UnitId && D.Ulevel == 2 && D.AuthorizedOfficer == false

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }
        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedActionTaken(int UnitId, string RollId)
        {
            var list = new List<int>() { 3, 4, 5, 6, 7 };

            var PendingList = new List<Test1>();
            decimal total = 0;

            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.AuthorizedOfficer == true && D.Ulevel == 2
                     && !list.Contains(D.UnitId)
                     orderby H.TransId
                     select new { H.TransId, g.Subject };

            int transid;
            int transid2 = 0;
            string details = string.Empty;

            int count = tg.Count();
            int temp = 0;

            foreach (var item in tg)
            {
                temp++;
                transid = item.TransId;
                if (transid2 == 0)
                {
                    transid2 = transid;

                }
                if (transid2 == transid)
                {
                    if (details.Length > 0)
                    {

                        details = details + "," + item.Subject.Trim();
                    }
                    else
                    {


                        details = item.Subject.Trim();
                    }
                    if (count == temp)
                    {
                        total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                        PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                        transid2 = transid;
                        details = item.Subject.Trim();

                    }
                }

                else
                {
                    total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                    PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                    transid2 = transid;
                    details = item.Subject.Trim();
                }
            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                                join K in _IRec.SubFinalPayDischargeTypes on H.Type equals K.Type
                                where D.UnitId == UnitId && D.Ulevel == 2 && D.AuthorizedOfficer == true

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }
        public async Task<IEnumerable<RecoveryCheckContract>> GetReceivedRec(int UnitId, string RollId)
        {
            var list = new List<int>() { 3, 4, 5, 6, 7 };

            var PendingList = new List<Test1>();
            decimal total = 0;

            var tg = from H in _IRec.SubFinalPayHeadDetails
                     join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                     join g in _IRec.SubAllowancesSubjects on D.UnitId equals g.SubId
                     where D.AuthorizedOfficer == false && D.Ulevel == 1
                     && !list.Contains(D.UnitId)
                     orderby H.TransId
                     select new { H.TransId, g.Subject };

            int transid;
            int transid2 = 0;
            string details = string.Empty;

            int count = tg.Count();
            int temp=0;

            foreach (var item in tg)
            {
                temp++;
                transid = item.TransId;
                if (transid2 == 0)
                {
                    transid2 = transid;

                }
                if (transid2 == transid)
                {
                    if (details.Length > 0)
                    {

                        details = details + "," + item.Subject.Trim();
                    }
                    else
                    {


                        details = item.Subject.Trim();
                    }
                    if (count == temp)
                    {
                        total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                        PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                        transid2 = transid;
                        details = item.Subject.Trim();

                    }
                }
                
                else
                {
                    total = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == transid2 select h.Amount).Sum());
                    PendingList.Add(new Test1 { TransId = transid2, PendingList = details, pending = true, Amount = total });
                    transid2 = transid;
                    details = item.Subject.Trim();
                }
            }



            var result = await (from H in _IRec.SubFinalPayHeadDetails
                                join D in _IRec.SubFinalPayDetails on H.TransId equals D.TransId
                                join K in _IRec.SubFinalPayDischargeTypes on H.Type equals K.Type
                                where D.UnitId == UnitId && D.Ulevel == 2 && D.SubjectClerk == false

                                select new RecoveryCheckContract
                                {
                                    TransID = H.TransId,
                                    SysCode = H.SysCode,
                                    CatCode = H.CatCode,
                                    OfficialNo = H.OfficialNo,
                                    Type = K.Des,
                                    DischargeDt = (DateTime)H.DischargeDt

                                }).ToListAsync();


            foreach (var t1 in PendingList)
            {
                foreach (var Item in result)
                {
                    if (t1.TransId == Item.TransID)
                    {
                        Item.Pending = t1.PendingList;
                        Item.IsPending = t1.pending;
                        Item.Amount = t1.Amount;
                        break;
                    }
                    else
                    {
                        Item.Amount = Convert.ToDecimal((from h in _IRec.SubFinalPayItemLists where h.TransId == Item.TransID select h.Amount).Sum());
                    }

                }

            }

            IEnumerable<RecoveryCheckContract> list1 = result;
            return list1;
        }
        public async Task<IEnumerable<SubRoleAllowance>> GetUsers(int UnitId)
        {
            return await _IRec.SubRoleAllowances.Where(S => S.Unit == UnitId && S.Active == true).ToListAsync();
        }
        public async Task<List<int>> GetForwardedRecovertList(int? TransId)
        {

            return await (from I in _IRec.SubFinalPayDetails
                          join L in _IRec.SubFinalPayHeadDetails
                          on I.TransId equals L.TransId
                          where I.TransId == TransId && I.Ulevel == 1 && I.AuthorizedOfficer == false
                          select I.TransId).ToListAsync();
        }

        public async Task<IEnumerable<SubRoleAllowance>> GetUsersDetails(int UnitId, string OfficialNo, string Role)
        {
            return await _IRec.SubRoleAllowances.Where(s => s.OfficialNo == OfficialNo && s.Unit == UnitId && s.Active == true && s.Role == Role.Trim()).ToListAsync();
        }
        public async Task updateUserDetails(int UnitId, string OfficialNo, string Role, string SysCode, string CatCode)
        {
            _IRec.SubRoleAllowances.Where(s => s.Unit == UnitId && s.Role.Trim() == Role.Trim() && s.Active == true).ToList().ForEach(a => { a.Active = false; a.DeactiveOn = DateTime.Now; });


            SubRoleAllowance t1 = new SubRoleAllowance();
            t1.SysCode = SysCode.Trim();
            t1.CatCode = CatCode.Trim();
            t1.OfficialNo = OfficialNo.Trim();
            t1.Unit = UnitId;
            t1.Role = Role.Trim();
            t1.BaseCode = _ILog.getBaseCode();
            t1.ActiveOn = DateTime.Now;
            t1.Active = true;

            await _IRec.SubRoleAllowances.AddAsync(t1);
            await _IRec.SaveChangesAsync();




        }

        public async Task<string> GetUnitName(int UnitId)
        {
            string UnitName =(await _IRec.SubAllowancesSubjects.Where(s=>s.SubId==UnitId).Select(s=>s.Subject).FirstAsync()).ToString();
            return UnitName;
        }
        public async Task UpdateRejectTrans(int TransId,int UnitId,string Reason)
        {
            _IRec.SubFinalPayDetails.Where(s => s.TransId == TransId && s.UnitId == UnitId && s.Ulevel == 1).ToList().ForEach(a => { a.AuthorizedOfficer = false; a.RejectReason = Reason; });
            await _IRec.SaveChangesAsync();
        }
    }
    class Test1
    {
        public int TransId;
        public string PendingList;
        public bool pending;
        public decimal Amount;
    }
}
