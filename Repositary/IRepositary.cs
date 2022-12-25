using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace FinaPay.Repositary
{
    public interface IRepositary
    {
        Task<WebService1SoapClient> GetInstanceAsync();
        Task<string> LoginAsync(string email,string password);

    }
}
