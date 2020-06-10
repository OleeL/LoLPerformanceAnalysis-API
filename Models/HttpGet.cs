using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static LoLPerformanceAnalysisAPI.Models.Routing;

namespace LoLPerformanceAnalysisAPI.Models
{
    public class HttpGet 
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient Client = new HttpClient();

        private const string HTTPS = "https://";

        private const string API_URL = "api.riotgames.com";

        private const string DATA_DRAGON_API_URL = HTTPS + "ddragon.leagueoflegends.com/api/";

        private const string API_URL_PREFIX = "?api_key=";
        
        private static string ApiKey;

        public static void setAPIKey(string key) => ApiKey = key;

        public async Task<string> PlatformGet(string request, string platform)
        {
            var responseBody = "";
            var url = HTTPS + platform + "." + API_URL + request;
            try	
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                requestMessage.Headers.Add("X-Riot-Token", ApiKey);
                var response = await Client.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode(); 
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch(HttpRequestException e)
            {
                FailedRequest(e, url);
            }
            return responseBody;
        }

        // Data dragon is for game data and assets
        // Builds like so: https://ddragon.leagueoflegends.com/api/<path>
        public async Task<string> DataDragonGet(string path)
        {
            var responseBody = "";
            try	
            {
                var response = await Client.GetAsync(DATA_DRAGON_API_URL+path);
                response.EnsureSuccessStatusCode(); 
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch(HttpRequestException e)
            {
                FailedRequest(e, DATA_DRAGON_API_URL+path);
            }
            return responseBody;
        }

        // Just a plain HTTP get. 
        public async Task<string> RawGet(string url)
        {
            var responseBody = "";
            try	
            {                          
                var response = await Client.GetAsync(url);
                response.EnsureSuccessStatusCode(); 
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch(HttpRequestException e)
            {
                FailedRequest(e, url);
            }
            return responseBody;
        }

        public void FailedRequest(HttpRequestException e, string Request)
        {
            Console.WriteLine("\nException Caught!");	
            Console.WriteLine("Message: {0} ",e.Message);
            Console.WriteLine("Request: {0} ", Request);
        }
    }

}