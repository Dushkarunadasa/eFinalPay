using FinaPay.Contract;
using FinaPay.Models;

namespace FinaPay.Services
{
    public interface IBaseRecovery
    {
        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransactions(string BaseCode);
        Task<IEnumerable<SubFinalPayHeadDetail>> Get327Transactions(string BaseCode,Boolean ActionTaken);

        Task<IEnumerable<SubFinalPay327List>> GetEnteredRecovertList(int? id);

        public int GetOrderID(int TransID);


        Task<string> UpdateFinalPay327ItemList(SubFinalPay327List obj);


        Task<IEnumerable<SubFinalPay327List>> Delete327Recovery(string TransId, int OrderId);


        Task<string> Forward327Recovery(int TransId, int UnitId, int Ulevel);

        Task<string> Forward327RecoveryByDDN(int TransId, int UnitId, int Ulevel);

        Task<string> Reject327ByDDN(int TransId, int UnitId, int Ulevel);
        

    }
}
