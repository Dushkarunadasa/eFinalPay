using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.PayModels;
using FinaPay.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Controllers
{
    public class PayOfficeController : Controller
    {
        IMainServices _Iss;
        IPayDetails _IPayIss;
        IRecoveryServices _Irec;
        ILoginDetails _Ilog;
        IBaseRecovery _IBaseRecoveries;
        private IHttpContextAccessor _accessor;
        public PayOfficeController(IMainServices Iss, IPayDetails IPayIss, IRecoveryServices Irec, ILoginDetails ilog, IHttpContextAccessor accessor, IBaseRecovery iBaseRecoveries)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _Irec = Irec;
            _Ilog = ilog;
            _accessor = accessor;
            _IBaseRecoveries = iBaseRecoveries;
            _Ilog.UpdateUserDetail(_accessor.HttpContext.Request.Cookies["SysCode"], _accessor.HttpContext.Request.Cookies["CatCode"], _accessor.HttpContext.Request.Cookies["officialNo"], _accessor.HttpContext.Request.Cookies["UserName"], _accessor.HttpContext.Request.Cookies["baseCode"], Convert.ToInt32(_accessor.HttpContext.Request.Cookies["UnitID"].ToString()), _accessor.HttpContext.Request.Cookies["UserRoll"]);



        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetAllTrans(_Ilog.getUnitID(), false);

            return View(AllTrans);
        }
        [Authorize]
        public async Task<IActionResult> EnteredListApprove()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetAllTrans(_Ilog.getUnitID(), false);
            return View(AllTrans);
        }
        [Authorize]
        public async Task<IActionResult> EnteredListApproved()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetAllTrans(_Ilog.getUnitID(), true);
            return View(AllTrans);
        }


        [Authorize]
        public async Task<IActionResult> PayRecovery()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _IPayIss.GetPayRecoveryPendingList(true);
            return View(AllTrans);
        }

        [Authorize]
        public async Task<IActionResult> EnteredList()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetAllTrans(_Ilog.getUnitID(), false);
            return View(AllTrans);
        }

        [Authorize]
        public IActionResult InitialEntry()
        {

            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            var FormDetails = new SubInitiateContract();
            FormDetails.Bases = new List<SelectListItem>();
            FormDetails.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"

            });
            foreach (var Base in BaseList)
            {
                FormDetails.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }


            return View(FormDetails);
        }
        [Authorize]
        public IActionResult BasicData()
        {
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            var FormDetails = new SubInitiateContract();
            FormDetails.Bases = new List<SelectListItem>();
            FormDetails.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"

            });
            foreach (var Base in BaseList)
            {
                FormDetails.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }
            return View(FormDetails);
        }

        [HttpPost]
        public async Task<IActionResult> InitialEntry(Contract.SubInitiateContract obj)
        {
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            obj.Bases = new List<SelectListItem>();
            obj.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"
            });
            foreach (var Base in BaseList)
            {
                obj.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }
            //BankCode 
            if (obj.OfficialNo != null)
            {
                IEnumerable<PayBank> BankList = _IPayIss.GetBankList(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo);
                obj.Bank = new List<SelectListItem>();
                obj.Bank.Add(new SelectListItem
                {
                    Text = "Select Bank",
                    Value = "0"
                });
                foreach (var bank in BankList)
                {
                    obj.Bank.Add(new SelectListItem { Text = bank.BankName, Value = bank.BankCode.ToString() });
                }
            }
            if (obj.OfficialNo.ToString().Trim() == "")
            {
                return ViewBag.Message = "First Search the naval person";
            }
            if (obj.OfficialNo != null)
            {
                var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if (Flist == null)
                {
                    int TransId = _Iss.GetTransID();
                    obj.TransId = TransId + 1;
                }
                else
                {
                    foreach (var ListT in Flist)
                    {
                        if (ListT.TransId != null)
                        {
                            obj.TransId = ListT.TransId;
                        }
                        if (ListT.Type != null)
                        {
                            obj.Type = ListT.Type.ToString();
                        }
                        if (ListT.NgReference != null)
                        {
                            obj.NgReference = ListT.NgReference.ToString();
                        }
                        if (ListT.DischargeDt != null)
                        {
                            obj.DischargeDt = ListT.DischargeDt;
                        }
                        if (ListT.PFormPath != null)
                        {
                            obj.PFormPath = ListT.PFormPath;
                        }
                        if (ListT.PForm != null)
                        {
                            obj.PForm = ListT.PForm;
                        }
                        if (ListT.BaseCode != null)
                        {
                            obj.BaseCode = ListT.BaseCode;
                        }
                        if (ListT.BankCode != null)
                        {
                            obj.BankCode = ListT.BankCode.ToString();
                        }
                        if (ListT.BranchCode != null)
                        {
                            obj.BranchCode = ListT.BranchCode.ToString();
                        }
                        if (ListT.AccountNo != null)
                        {
                            obj.AccountNo = ListT.AccountNo;
                        }
                        if (ListT.VoucherNo != null)
                        {
                            obj.VoucherNo = ListT.VoucherNo;
                        }
                        if (ListT.VoucherDes != null)
                        {
                            obj.VoucherDes = ListT.VoucherDes;
                        }
                        if (ListT.ChequeNo != null)
                        {
                            obj.ChequeNo = ListT.ChequeNo;
                        }
                        if (ListT.ChequeDt != null)
                        {
                            obj.ChequeDt = ListT.ChequeDt;
                        }
                        if (ListT.PaymentDt != null)
                        {
                            obj.PaymentDt = ListT.PaymentDt;
                        }
                        if (ListT.ActionComplete != null)
                        {
                            obj.ActionComplete = (Boolean)ListT.ActionComplete;
                        }
                        if (ListT.Remarks != null)
                        {
                            obj.Remarks = ListT.Remarks;
                        }
                    }
                }

            }
            return View(obj);
        }

        public async Task<IActionResult> BasicDataAuthorizedEdit(int TransId)

        {
            Contract.ProfileUpdateBasicContract obj = new ProfileUpdateBasicContract();
            obj.TransId = TransId;
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            obj.Bases = new List<SelectListItem>();
            obj.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"
            });
            foreach (var Base in BaseList)
            {
                obj.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }
            var Flist = await _Iss.LoadExistingTransDetail(TransId);
            foreach (var ListT in Flist)
            {

                obj.OfficialNo = ListT.OfficialNo;
                obj.SysCode = ListT.SysCode;
                obj.CatCode = ListT.CatCode;
                if (ListT.Type != null)
                {
                    obj.Type = ListT.Type.ToString();
                }
                if (ListT.NgReference != null)
                {
                    obj.NgReference = ListT.NgReference.ToString();
                }
                if (ListT.DischargeDt != null)
                {
                    DateTime DcDt = (DateTime)ListT.DischargeDt;
                    obj.DischargeDt = ListT.DischargeDt;
                }
                if (ListT.BaseCode != null)
                {
                    obj.BaseCode = ListT.BaseCode;
                }
            }
            return View(obj);
        }

        public async Task<IActionResult> BasicDataEdit(int TransId)

        {
            Contract.ProfileUpdateBasicContract obj = new ProfileUpdateBasicContract();
            obj.TransId = TransId;
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            obj.Bases = new List<SelectListItem>();
            obj.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"
            });
            foreach (var Base in BaseList)
            {
                obj.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }



            var Flist = await _Iss.LoadExistingTransDetail(TransId);
            foreach (var ListT in Flist)
            {

                obj.OfficialNo = ListT.OfficialNo;
                obj.SysCode = ListT.SysCode;
                obj.CatCode = ListT.CatCode;
                if (ListT.Type != null)
                {
                    obj.Type = ListT.Type.ToString();
                }
                if (ListT.NgReference != null)
                {
                    obj.NgReference = ListT.NgReference.ToString();
                }
                if (ListT.DischargeDt != null)
                {
                    DateTime DcDt = (DateTime)ListT.DischargeDt;
                    obj.DischargeDt = ListT.DischargeDt;
                }

                if (ListT.BaseCode != null)
                {
                    obj.BaseCode = ListT.BaseCode;
                }





            }
            return View(obj);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Search(Contract.SubInitiateContract obj)
        {
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            obj.Bases = new List<SelectListItem>();
            obj.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"

            });
            foreach (var Base in BaseList)
            {
                obj.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }
            if (obj.OfficialNo != null)
            {
                //BankCode 
                IEnumerable<PayBank> BankList = _IPayIss.GetBankList(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                obj.Bank = new List<SelectListItem>();
                obj.Bank.Add(new SelectListItem
                {
                    Text = "Select Bank",
                    Value = "0"

                });
                foreach (var bank in BankList)
                {
                    obj.Bank.Add(new SelectListItem { Text = bank.BankName, Value = bank.BankCode.ToString() });
                }
            }
            if (obj.OfficialNo == null)
            {
                return ViewBag.Message = "First Search the naval person";
            }


            if (obj.OfficialNo != null)
            {
                var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if (Flist == null)
                {
                    int TransId = _Iss.GetTransID();
                    obj.TransId = TransId + 1;
                }
                else
                {
                    foreach (var ListT in Flist)
                    {
                        if (ListT.TransId != null)
                        {
                            obj.TransId = ListT.TransId;
                        }
                        if (ListT.Type != null)
                        {
                            obj.Type = ListT.Type.ToString();
                        }
                        if (ListT.NgReference != null)
                        {
                            obj.NgReference = ListT.NgReference.ToString();
                        }
                        if (ListT.DischargeDt != null)
                        {
                            obj.DischargeDt = ListT.DischargeDt;
                        }
                        if (ListT.PFormPath != null)
                        {
                            obj.PFormPath = ListT.PFormPath;
                        }
                        if (ListT.PForm != null)
                        {
                            obj.PForm = ListT.PForm;
                        }
                        if (ListT.BaseCode != null)
                        {
                            obj.BaseCode = ListT.BaseCode;
                        }
                        if (ListT.BankCode != null)
                        {
                            obj.BankCode = ListT.BankCode.ToString();
                        }
                        if (ListT.BranchCode != null)
                        {
                            obj.BranchCode = ListT.BranchCode.ToString();
                        }
                        if (ListT.AccountNo != null)
                        {
                            obj.AccountNo = ListT.AccountNo;
                        }
                        if (ListT.VoucherNo != null)
                        {
                            obj.VoucherNo = ListT.VoucherNo;
                        }
                        if (ListT.VoucherDes != null)
                        {
                            obj.VoucherDes = ListT.VoucherDes;
                        }
                        if (ListT.ChequeNo != null)
                        {
                            obj.ChequeNo = ListT.ChequeNo;
                        }
                        if (ListT.ChequeDt != null)
                        {
                            obj.ChequeDt = ListT.ChequeDt;
                        }
                        if (ListT.PaymentDt != null)
                        {
                            obj.PaymentDt = ListT.PaymentDt;
                        }
                        if (ListT.ActionComplete != null)
                        {
                            obj.ActionComplete = (Boolean)ListT.ActionComplete;
                        }
                        if (ListT.Remarks != null)
                        {
                            obj.Remarks = ListT.Remarks;
                        }
                    }
                }
                //  return RedirectToAction("ini");
            }
            return View("InitialEntry", obj);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PersonSearch(Contract.SubInitiateContract obj)
        {
            IEnumerable<PayBase> BaseList = _IPayIss.GetBaseList();
            obj.Bases = new List<SelectListItem>();
            obj.Bases.Add(new SelectListItem
            {
                Text = "Select Base",
                Value = "0"

            });
            foreach (var Base in BaseList)
            {
                obj.Bases.Add(new SelectListItem { Text = Base.BaseName, Value = Base.BaseCode.ToString() });
            }

            if (obj.OfficialNo == null)
            {
                TempData["success"] = "Official No cannot be empty";
            }
            else
            {
                var result = _IPayIss.GetPerInfo(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if ((result == null) || (result.Count() == 0))
                {
                    TempData["success"] = "Invalid Official No,Please Check the Official No";
                }
                else
                {
                    foreach (var Data in result)
                    {
                        TempData["success"] = Data.Initials.ToString() + "" + Data.SurName.ToString();
                    }
                }
            }
            if (obj.OfficialNo != null)
            {
                var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if (Flist == null)
                {
                    int TransId = _Iss.GetTransID();
                    obj.TransId = TransId + 1;
                }
                else
                {
                    foreach (var ListT in Flist)
                    {
                        if (ListT.TransId != null)
                        {
                            obj.TransId = ListT.TransId;
                        }
                        if (ListT.Type != null)
                        {
                            obj.Type = ListT.Type.ToString();
                        }
                        if (ListT.NgReference != null)
                        {
                            obj.NgReference = ListT.NgReference.ToString();
                        }
                        if (ListT.DischargeDt != null)
                        {
                            obj.DischargeDt = ListT.DischargeDt;
                        }
                        if (ListT.PFormPath != null)
                        {
                            obj.PFormPath = ListT.PFormPath;
                        }
                        if (ListT.PForm != null)
                        {
                            obj.PForm = ListT.PForm;
                        }
                        if (ListT.BaseCode != null)
                        {
                            obj.BaseCode = ListT.BaseCode;
                        }
                        if (ListT.BankCode != null)
                        {
                            obj.BankCode = ListT.BankCode.ToString();
                        }
                        if (ListT.BranchCode != null)
                        {
                            obj.BranchCode = ListT.BranchCode.ToString();
                        }
                        if (ListT.AccountNo != null)
                        {
                            obj.AccountNo = ListT.AccountNo;
                        }
                        if (ListT.VoucherNo != null)
                        {
                            obj.VoucherNo = ListT.VoucherNo;
                        }
                        if (ListT.VoucherDes != null)
                        {
                            obj.VoucherDes = ListT.VoucherDes;
                        }
                        if (ListT.ChequeNo != null)
                        {
                            obj.ChequeNo = ListT.ChequeNo;
                        }
                        if (ListT.ChequeDt != null)
                        {
                            obj.ChequeDt = ListT.ChequeDt;
                        }
                        if (ListT.PaymentDt != null)
                        {
                            obj.PaymentDt = ListT.PaymentDt;
                        }
                        if (ListT.ActionComplete != null)
                        {
                            obj.ActionComplete = (Boolean)ListT.ActionComplete;
                        }
                        if (ListT.Remarks != null)
                        {
                            obj.Remarks = ListT.Remarks;
                        }
                    }
                }

            }
            return View("BasicData", obj);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Contract.SubInitiateContract obj)
        {


            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}


            string IP = GetIPAddress();
            var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
            if (Flist.Count() == 0)
            {
                int TransId = _Iss.GetTransID();
                obj.TransId = TransId + 1;
                var Message = await _Iss.CreateInitialTransaction(obj, obj.TransId, _Ilog.getUnitID());

                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " enteterd initial details(" + obj.SysCode.ToString() + obj.CatCode.ToString() + obj.OfficialNo.ToString() + obj.OfficialNo.ToString() + ")", Logtime = DateTime.Now, Ip = IP });

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateProfile(ProfileUpdateBasicContract obj)
        {

            if (obj.OfficialNo == null)
            {
                TempData["success"] = "Offical No empty";


            }
            else if (obj.Type.ToString() == "0")
            {

                TempData["success"] = "Discharge Type empty";

            }
            else if (obj.BaseCode == null || obj.BaseCode == "0")
            {

                TempData["success"] = "Base/Ship Cannot be empty";

            }
            else
            {


                string IP = GetIPAddress();
                var Message = await _Iss.UpdateProfile(obj, obj.TransId);
                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = obj.TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " enteterd initial details(" + obj.SysCode.ToString() + obj.CatCode.ToString() + obj.OfficialNo.ToString() + obj.OfficialNo.ToString() + ")", Logtime = DateTime.Now, Ip = IP });

                TempData["success"] = "Successfully updated";
            }
            if ("Subject Clerk" == _Ilog.GetUserRoll().ToString())
            {

                return RedirectToAction("BasicDataEdit", new { obj.TransId });
            }
            else
            {
                return RedirectToAction("BasicDataAuthorizedEdit", new { obj.TransId });
            }
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateProfile(Contract.SubInitiateContract obj)
        {
            if (obj.OfficialNo == null)
            {
                TempData["success"] = "Offical No empty";

            }
            else if (obj.Type.ToString() == "0")
            {

                TempData["success"] = "Discharge Type empty";
            }
            else if (obj.BaseCode == null)
            {

                TempData["success"] = "Base/Ship Cannot be empty";
            }
            else if ((20 == _Ilog.getUnitID() || 21 == _Ilog.getUnitID() || 22 == _Ilog.getUnitID() || 23 == _Ilog.getUnitID()) && (obj.CatCode.ToString() == "O"))
            {
                TempData["success"] = "DNP staff cannot enter officer's Details";
            }
            else if ((5 == _Ilog.getUnitID() || 6 == _Ilog.getUnitID() || 7 == _Ilog.getUnitID()) && obj.CatCode.ToString() == "S")
            {
                TempData["success"] = "P/Sec & A/Sec cannot enter Sailor's Details";
            }
            else
            {

                var result = _IPayIss.GetPerInfo(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if ((result == null) || (result.Count() == 0))
                {
                    TempData["success"] = "Invalid Official No,Please Check the Official No";
                }
                else
                {
                    string IP = GetIPAddress();
                    var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                    if (Flist.Count() == 0)
                    {
                        int TransId = _Iss.GetTransID();
                        obj.TransId = TransId + 1;
                        var Message = await _Iss.CreateInitialTransaction(obj, obj.TransId, _Ilog.getUnitID());
                        ViewBag.Message = Message;
                        TempData["success"] = Message;
                        await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " enteterd initial details(" + obj.SysCode.ToString() + obj.CatCode.ToString() + obj.OfficialNo.ToString() + obj.OfficialNo.ToString() + ")", Logtime = DateTime.Now, Ip = IP });
                        TempData["success"] = "Successfully Entered,Enter New one";
                    }
                    else
                    {

                        TempData["success"] = "Already Exist";
                    }
                }
            }
            return RedirectToAction("BasicData");
        }

        public JsonResult GetBankBrnach(string BankCode, string SysCode, String CatCode, String OfficialNo)
        {
            var BankBranchList = _IPayIss.GetBranchList(BankCode, SysCode, CatCode, OfficialNo);

            return Json(BankBranchList);
        }
        public JsonResult GetBankAccount(String SysCode, String catCode, String OfficialNo, string BankCode, string BranchCode)
        {
            var BankAccountList = _IPayIss.GetAccountList(SysCode, catCode, OfficialNo, BankCode, BranchCode);
            return Json(BankAccountList);
        }
        public async Task<IActionResult> RecoveryPendingListDDN()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _Irec.GetReceivedRecDDN(_Ilog.getUnitID(), _Ilog.GetUserRoll(), 4);
            return View(AllTrans);
        }
        public async Task<IActionResult> RecoveryForwardedListDDN()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _Irec.GetForwardedRecDDN(_Ilog.getUnitID(), _Ilog.GetUserRoll(), 4);
            return View(AllTrans);
        }
        public async Task<IActionResult> EditAuth(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _Irec.GetReceiveRecDetails(id);
            return View(AllTrans);

        }

        public async Task<IActionResult> BasicDataApprove(int TransId)
        {


            string IP = GetIPAddress();
            var Message = await _Iss.ApproveProfile(TransId);
            await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " enteterd initial details approved)", Logtime = DateTime.Now, Ip = IP });
            TempData["success"] = "Approved";

            return RedirectToAction("EnteredListApprove");
        }
        public async Task<IActionResult> DeleteProfile(int TransId)
        {
            var result = await _Irec.DeleteProfile(TransId);
            string IP = GetIPAddress();
            await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " deleted " + TransId, Logtime = DateTime.Now, Ip = IP });

            return RedirectToAction("EnteredList");
        }
        public async Task<IActionResult> RecDetails(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _Irec.GetReceiveRecDetails(id);
            return View(AllTrans);

        }
        public async Task<IActionResult> ForwardRecoveryAuth(int id)
        {
            var result = await _Irec.ForwardSubRecovery(id, _Ilog.getUnitID(), 4);
            string IP = GetIPAddress();
            await _Irec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " transaction Forward for action-Final Pay Unit", Logtime = DateTime.Now, Ip = IP });
            return RedirectToAction("RecoveryPendingListDDN");


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PayRecoveryInsert(Contract.SubPayReEntryContract obj)
        {

            Boolean formvalid = true;
            int TransId = (int)obj.TransId;
            string ItemCode = obj.ItemName;

            if (obj.ItemName == "0")
            {
                ViewBag.Message = "First select the Recovery Item";
                formvalid = false;
            }
            else if (obj.Amount <= 0)
            {
                ViewBag.Message = "Please enter amount";
                formvalid = false;
            }
            else if (obj.NofDays <= 0)
            {
                ViewBag.Message = "Please enter No of days";
                formvalid = false;
            }
            else if (obj.IAmount <= 0)
            {
                ViewBag.Message = "Please recheck amount and nof days";
                formvalid = false;
            }




            decimal TransAmount = obj.IAmount;

            if (formvalid == true)
            {
                ViewBag.Message = await _Irec.UpdateFinalPayItemList(TransId, _Ilog.getUnitID(), ItemCode.Trim(), TransAmount, "From Last Pay");
                string IP = GetIPAddress();
                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " Inserted :" + ItemCode + "Amount :" + TransAmount, Logtime = DateTime.Now, Ip = IP });

            }

            if (formvalid == false)
            {
                IEnumerable<SubFinalPayItem> ItemList = await _Irec.AllPayItemFromLastPay(TransId, _Ilog.getUnitID());
                var FormDetails = new SubPayReEntryContract();
                FormDetails.ItemCode = new List<SelectListItem>();
                FormDetails.ItemCode.Add(new SelectListItem
                {
                    Text = "Select Item Code",
                    Value = "0"

                });
                foreach (var IList in ItemList)
                {
                    FormDetails.ItemCode.Add(new SelectListItem { Text = IList.ItemDescription, Value = IList.ItemCode.ToString() });
                }

                FormDetails.TransId = TransId;
                return View("RecoveryEntry", FormDetails);
            }
            else
            {
                return RedirectToAction("RecoveryEntry", new { id = TransId });
            }




        }

        public async Task<IActionResult> RecoveryPendingList()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _Irec.GetReceivedRec(16, "1");
            return View(AllTrans);
        }

        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }

        public async Task<IActionResult> Allowance327DDN()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Irec.GetReceived327DDN(false);
            return View(AllTrans);
        }
        public async Task<IActionResult> Details327(int? id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubFinalPay327List> ListRec = await _IBaseRecoveries.GetEnteredRecovertList(id);
            return View(ListRec);

        }
        public async Task<IActionResult> ForwardToAction(int id)
        {

            var recresult = await _IBaseRecoveries.GetEnteredRecovertList(id);

            if (recresult == null || recresult.Count() <= 0)
            {
                ViewBag.Error = "If no 327 Allowances, then Zero value 327 allowances is required";
                // return NotFound();
            }
            else
            {

                var result = await _IBaseRecoveries.Forward327RecoveryByDDN(id, _Ilog.getUnitID(), 1);
                string IP = GetIPAddress();
                string remarks = "DDN(Pay) Forwarded to Action";
                string userRole = _Ilog.GetUserRoll();


                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + remarks, Logtime = DateTime.Now, Ip = IP });

            }
            return RedirectToAction("Allowance327DDN");
        }
        public async Task<IActionResult> Reject327DDN(int id)
        {

            var recresult = await _IBaseRecoveries.GetEnteredRecovertList(id);

            if (recresult == null || recresult.Count() <= 0)
            {
                ViewBag.Error = "If no 327 Allowances, then Zero value 327 allowances is required";
                // return NotFound();
            }
            else
            {

                var result = await _IBaseRecoveries.Reject327ByDDN(id, _Ilog.getUnitID(), 1);
                string IP = GetIPAddress();
                string remarks = "DDN(Pay) Rejected";
                string userRole = _Ilog.GetUserRoll();


                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + remarks, Logtime = DateTime.Now, Ip = IP });

            }
            return RedirectToAction("Allowance327DDN");
        }

        public async Task<IActionResult> RecList(int? id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubPayRecoveryContrat> ListRec = await _Irec.GetEnteredPayRecovertList(id);
            return View(ListRec);


        }






        public async Task<IActionResult> RecoveryEntry(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            int TransId = (int)id;

            IEnumerable<SubFinalPayItem> ItemList = await _Irec.AllPayItemFromLastPay(TransId, _Ilog.getUnitID());
            var FormDetails = new SubPayReEntryContract();
            FormDetails.ItemCode = new List<SelectListItem>();
            FormDetails.ItemCode.Add(new SelectListItem
            {
                Text = "Select Item Code",
                Value = "0"

            });
            foreach (var IList in ItemList)
            {
                FormDetails.ItemCode.Add(new SelectListItem { Text = IList.ItemDescription, Value = IList.ItemCode.ToString() });
            }
            FormDetails.TransId = id;


            return View(FormDetails);



        }

        public async Task<IActionResult> RecoveryOtherEntry(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            int TransId = (int)id;

            IEnumerable<SubFinalPayItem> ItemList = await _Irec.AllPayItems();
            var FormDetails = new SubPayReEntryContract();
            FormDetails.ItemCode = new List<SelectListItem>();
            FormDetails.ItemCode.Add(new SelectListItem
            {
                Text = "Select Item Code",
                Value = "0"

            });
            foreach (var IList in ItemList)
            {
                FormDetails.ItemCode.Add(new SelectListItem { Text = IList.ItemDescription, Value = IList.ItemCode.ToString() });
            }
            FormDetails.TransId = id;


            return View("RecoveryEntry", FormDetails);



        }
    }
}
