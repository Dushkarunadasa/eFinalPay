using System.Data;
using System.ServiceModel;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ServiceReference1;

namespace FinaPay.Repositary
{
    public class Repositary :IRepositary
    {
        private readonly IConfiguration _configuration;
        public readonly string serviceUrl = "http://10.40.6.4:178/WebService1.asmx?WSDL";
        public readonly EndpointAddress endpointAddress;
        public readonly BasicHttpBinding basicHttpBinding;
        public Repositary(IConfiguration configuration)
        {
            _configuration = configuration;

            endpointAddress = new EndpointAddress(serviceUrl);

            basicHttpBinding =
                new BasicHttpBinding(endpointAddress.Uri.Scheme.ToLower() == "http" ?
                            BasicHttpSecurityMode.None : BasicHttpSecurityMode.Transport);

            basicHttpBinding.OpenTimeout = TimeSpan.MaxValue;
            basicHttpBinding.CloseTimeout = TimeSpan.MaxValue;
            basicHttpBinding.ReceiveTimeout = TimeSpan.MaxValue;
            basicHttpBinding.SendTimeout = TimeSpan.MaxValue;
        }
        public async Task<WebService1SoapClient> GetInstanceAsync()
        {
            return await Task.Run(() => new WebService1SoapClient(basicHttpBinding, endpointAddress));
        }
        public async Task<string> LoginAsync(string email,string password)
        {
            string msg;
            string code;

            try
            {
                var client = await GetInstanceAsync();
                var result = await client.UserValidityAsync(email,password);

            
                msg = JsonConvert.DeserializeObject<string>(result.Body.UserValidityResult.ToString());

               

           
            }
            catch (Exception ex)
            {
                code= "";
                msg = ex.Message;
            }


          

            return msg;
        }

    
    }
}
