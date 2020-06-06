
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using LoLPerformanceAnalysisAPI.Models;

namespace LoLPerformanceAnalysisAPI.Controllers
{

    public interface IClientHub
    {
        Task UpdateGameInfo(string user, string message);
    }


    public class ClientHub : Hub<IClientHub>
    {
        public Requests requests = new Requests();

        public override async Task OnConnectedAsync() =>
            await base.OnConnectedAsync();

        public override async Task OnDisconnectedAsync(Exception exception) =>
            await base.OnDisconnectedAsync(exception);

        public async Task<string> GetSummonerName(string summonerName, string serverRegion) =>
            await requests.GetSummonerId(summonerName, serverRegion);

        public async Task<string> GetChampionDetails(string champion) =>
            await requests.GetChampion(champion);
    
        public async Task<string> GetChampionRotations(string platform) =>
            await requests.GetChampionRotations(platform);

        
    }
}
