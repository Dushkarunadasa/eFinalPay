using FinaPay.HRMSModels;

namespace FinaPay.Services
{
    public interface IHrmsDetails
    {
        Task<IEnumerable<HrisTPersonalDatum>> GetHRMSDateils(string email);
    }
}
