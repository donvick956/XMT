using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GroupExperiment.Modules.Utils
{
    public class NetworkUtil
    {
         static string uri = "https://localhost:5001/";
        public static  HttpClient client;
        HttpClientHandler insecureHandler;

        public NetworkUtil()
        {
            insecureHandler = GetInsecureHandler();
            client = new HttpClient(insecureHandler);
        }



        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }


        //public static async Task<string> GeneralPostRequest(string actioName, string jsonData)
        //{
        //    string result = string.Empty;
        //    try
        //    {
        //       // HttpResponseMessage response = await client.PostAsJsonAsync($"{}", user);

        //        var responseContent = await response.Content.ReadAsStringAsync();
        //    }
        //    catch (Exception e) {

        //        result = e.Message;
        //    }
        //    return result;

        //}


    }
}
