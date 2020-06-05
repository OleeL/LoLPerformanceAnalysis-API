using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
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

        public string GetSummonerName(string summonerName, string serverRegion) => "API has received "+summonerName+" from "+serverRegion;
    
        public async Task<string> GetChampionRotations(string platform) => await Requests.GetChampionRotations(platform);

    }
}
