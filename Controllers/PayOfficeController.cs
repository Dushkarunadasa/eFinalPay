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
        private IHttpContextAccessor _accessor;
        public PayOfficeController(IMainServices Iss, IPayDetails IPayIss, IRecoveryServices Irec, ILoginDetails ilog, IHttpContextAccessor accessor)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _Irec = Irec;
            _Ilog = ilog;
            _accessor = accessor;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetAllTrans();

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

            //BankCode 
            //IEnumerable<PayBank> BankList = _IPayIss.GetBankList();
            //FormDetails.Bank = new List<SelectListItem>();
            //FormDetails.Bank.Add(new SelectListItem
            //{
            //    Text = "Select Bank",
            //    Value = "0"

            //});
            //foreach (var bank in BankList)
            //{
            //    FormDetails.Bank.Add(new SelectListItem { Text = bank.BankName, Value = bank.BankCode.ToString() });
            //}
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
        public async Task<IActionResult> Create(Contract.SubInitiateContract obj)
        {
            string IP = GetIPAddress();
            var Flist = await _Iss.GetExistingTransDetails(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
            if (Flist.Count() == 0)
            {
                int TransId = _Iss.GetTransID();
                obj.TransId = TransId + 1;
                var Message = await _Iss.CreateInitialTransaction(obj, obj.TransId);
               
                await _Irec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _Ilog.getUnitID(), UserId = _Ilog.getUserName().ToString(), LogDetails = _Ilog.GetUserRoll().ToString() + " enteterd initial details("+ obj.SysCode.ToString()+ obj.CatCode.ToString()+ obj.OfficialNo.ToString()+ obj.OfficialNo.ToString()+")", Logtime = DateTime.Now, Ip = IP });

            }
            return RedirectToAction("Index");
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
            IEnumerable<RecoveryCheckContract> AllTrans = await _Irec.GetReceivedRecDDN(_Ilog.getUnitID(), _Ilog.GetUserRoll(),4);
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
    }
}
