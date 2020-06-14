using System.Threading.Tasks;
using static LoLPerformanceAnalysisAPI.Models.Routing;
using System.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models
{

    public class LoLRequest
    {
        public HttpGet Request = new HttpGet();

        public List<string> Versions;

        public string LatestVersion = "10.11.1";

        public LoLRequest() => Task.WhenAll(UpdateVersion());

        public async Task UpdateVersion()
        {
            var result = await GetVersions();
            if (result.Count > 0) {
                Versions = result;
                LatestVersion = Versions[0];
            }
        }
    
        public async Task<string> GetChampionRotations(string platform) =>
            await Request.PlatformGet("/lol/platform/v3/champion-rotations", ClientPlatformToPlatform(platform));

        public async Task<string> GetSummonerId(string summonerName, string serverRegion) =>
            await Request.PlatformGet("/lol/summoner/v4/summoners/by-name/"+summonerName, ClientPlatformToPlatform(serverRegion));

        public async Task<string> GetSummonerRank(string id, string serverRegion) =>
            await Request.PlatformGet("/lol/league/v4/entries/by-summoner/"+id, ClientPlatformToPlatform(serverRegion));

        public async Task<string> GetChampion(string name) =>
            await Request.DataDragonGet(name);

        public async Task<List<string>> GetVersions() {
            var rawJson = await Request.DataDragonGet("versions.json");
            return JsonConvert.DeserializeObject<List<string>>(rawJson);
        }
    }

}