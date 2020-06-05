using System;
using System.Net.Http;
using System.Threading.Tasks;
using static LoLPerformanceAnalysisAPI.Models.Routing;

namespace LoLPerformanceAnalysisAPI.Models
{
    public class HttpGet 
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        private static string API_KEY;

        public static void setAPIKey(string key) => API_KEY = key;

        private const string API_URL = "api.riotgames.com";

        private const string API_URL_PREFIX = "?api_key=";
        
        private const string HTTPS = "https://";

        public async Task<string> SendAsync(string request, string platform)
        {
            var responseBody = "";

            try	
            {
                var url = HTTPS +
                          platform + 
                          "." +
                          API_URL + 
                          request + 
                          API_URL_PREFIX +
                          API_KEY;
                          
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); 
                responseBody = await response.Content.ReadAsStringAsync();

                // Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
            Console.WriteLine(responseBody);
            return responseBody;
        }
    }

}