using System.Threading.Tasks;
using static LoLPerformanceAnalysisAPI.Models.Routing;
using System.Configuration;

namespace LoLPerformanceAnalysisAPI.Models
{

    public class Requests 
    {
        public static HttpGet Request = new HttpGet();
    
        public static async Task<string> GetChampionRotations(string platform) => await Request.SendAsync("/lol/platform/v3/champion-rotations", platform);

        public string GetSummonerId(string summonerName) => "";
    }

}