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

        private const string API_URL = "api.riotgames.com";

        public HttpGet (string API_KEY) => HttpGet.API_KEY = "?api_key="+API_KEY;

        public async Task<string> SendAsync(string request, Platform platform)
        {
            var responseBody = "";
            var route = Routing.PlatformToString(platform);

            try	
            {
                var response = await client.GetAsync(route + API_URL + request + API_KEY);
                response.EnsureSuccessStatusCode(); 
                responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
            return responseBody;
        }
    }

}