using FinaPay.HRMSModels;
using FinaPay.Models;
using Microsoft.EntityFrameworkCore;


namespace FinaPay.Services
{
    public class HrmsDetails:IHrmsDetails
    {
        private readonly HRISLIVEContext _db;
        public HrmsDetails(HRISLIVEContext db)
        {
            _db = db;
        }
        async Task<IEnumerable<HrisTPersonalDatum>> IHrmsDetails.GetHRMSDateils(string email)
        {
            IEnumerable<HrisTPersonalDatum> HRMSData = await _db.HrisTPersonalData.Where(s=>s.EmailAddress==email).ToListAsync();
            return HRMSData;
        }
    }
}
