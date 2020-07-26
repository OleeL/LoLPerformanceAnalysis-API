
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
        public async Task<Summoner> GetSummoner(string summonerName, string serverRegion){
            if (summonerName == null || summonerName == "") return null;
            var summoner = TryGetSummoner(Context.ConnectionId);
            if (summoner != null || summoner?.name == summonerName) return summoner;
            summoner = JsonConvert.DeserializeObject<Summoner>(await Requests.GetSummonerId(summonerName, serverRegion));
            summoner.leagueEntry = JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(await Requests.GetSummonerLeagueEntry(summoner.id, serverRegion));
            summoner.matchList = JsonConvert.DeserializeObject<MatchlistDTO>(await Requests.GetMatchHistory(summoner.accountId, serverRegion));
            TryStoreSummoner(Context.ConnectionId, summoner);
            return summoner;
        }

        public async Task<string> GetChampionDetails(string champion) =>
            await Requests.GetChampion(champion);
    
        public async Task<string> GetChampionRotations(string platform) =>
            await Requests.GetChampionRotations(platform);
        
        #endregion
    }
}
