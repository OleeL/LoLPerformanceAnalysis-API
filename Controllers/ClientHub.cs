
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using LoLPerformanceAnalysisAPI.Models;
using Newtonsoft.Json;
using static LoLPerformanceAnalysisAPI.Models.Summoner;

namespace LoLPerformanceAnalysisAPI.Controllers
{
    public interface IClientHub
    {
        Task UpdateGameInfo(string user, string message);
    }

    public class ClientHub : Hub<IClientHub>
    {
        public static LoLRequest Requests = new LoLRequest();

        public override async Task OnConnectedAsync() =>
            await base.OnConnectedAsync();

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
            TryRemoveSummoner(Context.ConnectionId);
        }

        public async Task<Summoner> GetSummoner(string summonerName, string serverRegion){
            var summoner = TryGetSummoner(Context.ConnectionId);
            if (summoner?.name == summonerName) return summoner;
            summoner = JsonConvert.DeserializeObject<Summoner>(await Requests.GetSummonerId(summonerName, serverRegion));
            TryStoreSummoner(Context.ConnectionId, summoner);
            return summoner;
        }

        public async Task<string> GetChampionDetails(string champion) =>
            await Requests.GetChampion(champion);
    
        public async Task<string> GetChampionRotations(string platform) =>
            await Requests.GetChampionRotations(platform);
    }
}
