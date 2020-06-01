using System;
using System.Net.Http;
using System.Threading.Tasks;
using static LoLPerformanceAnalysisAPI.Models.Routing;

namespace LoLPerformanceAnalysisAPI.Models
{
    public class Requests 
    {
        

        public static string GetChampionRotations() {
            SendAsync("/lol/platform/v3/champion-rotations");
        }
    }

}