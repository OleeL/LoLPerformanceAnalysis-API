
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using LoLPerformanceAnalysisAPI.Models;
using Newtonsoft.Json;
using static LoLPerformanceAnalysisAPI.Models.Summoner;
using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Controllers
{
    public interface IClientHub
    {
        Task UpdateGameInfo(string user, string message);
    }

    public class ClientHub : Hub<IClientHub>
    {
        #region [rgba(126, 75, 27, 0.15)] Other
        public static LoLRequest Requests = new LoLRequest();

        public override async Task OnConnectedAsync() =>
            await base.OnConnectedAsync();

        public override async Task OnDisconnectedAsync(Exception exception) {
            await base.OnDisconnectedAsync(exception);
            TryRemoveSummoner(Context.ConnectionId);
        }
        #endregion

        #region [ClientGets]
        // Gets all information of a summoner. Stores it locally to prevent spam
        public async Task<Summoner> GetSummoner(string summonerName, string serverRegion){
            // Input validation and prevents multiple requests for one summoner
            if (summonerName == null || summonerName == "") return null;
            var summoner = TryGetSummoner(Context.ConnectionId);
            if (summoner != null || summoner?.name == summonerName) return summoner;
            summoner = JsonConvert.DeserializeObject<Summoner>(await Requests.GetSummonerId(summonerName, serverRegion));

            // Getting league entry
            var leagueEntry = await Requests.GetSummonerLeagueEntry(summoner.id, serverRegion);
            summoner.leagueEntry = JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(leagueEntry);

            // Getting match list
            var matchList = await Requests.GetMatchHistory(summoner.accountId, serverRegion);
            summoner.matchList = JsonConvert.DeserializeObject<MatchlistDTO>(matchList);

            // Stores the summoner locally
            TryStoreSummoner(Context.ConnectionId, summoner);
            return summoner;
        }

        // Gets champion details
        public async Task<string> GetChampionDetails(string champion) =>
            await Requests.GetChampion(champion);
    
        // Gets champion rotations
        public async Task<string> GetChampionRotations(string platform) =>
            await Requests.GetChampionRotations(platform);
        
        #endregion
    }
}
