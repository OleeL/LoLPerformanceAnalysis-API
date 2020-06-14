using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class Summoner {
        #region [StaticAttributes]
        public static Dictionary<string, Summoner> ClientSummoner = new Dictionary<string, Summoner>();
        public static bool ClientSummonerExists(string id) => ClientSummoner.ContainsKey(id) && ClientSummoner[id] != null;
        #endregion

        #region [Attributes]
        public string accountId { get; set; }   // Encrypted account ID. Max length 56 characters.
        public int profileIconId { get; set; }  // ID of the summoner icon associated with the summoner.
        public long revisionDate { get; set; }  // Time since epoch (summoner last edited, played a game, changed profile pic);
        public string name { get; set; }        // Summoner name.
        public string id { get; set; }          // Encrypted summoner ID. Max length 63 characters.
        public string puuid { get; set; }       // Encrypted PUUID. Exact length of 78 characters.
        public long summonerLevel { get; set; } // Summoner level associated with the summoner.
        public List<LeagueEntryDTO>? leagueEntry { get; set; }
        #endregion
        
        #region [Methods]
        public static void TryStoreSummoner(string ConnectionId, Summoner summoner)
        {
            if (!ClientSummoner.ContainsKey(ConnectionId)) {
                ClientSummoner.Add(ConnectionId, summoner);
                return;
            }
            ClientSummoner[ConnectionId] = summoner;
        }

        public static Summoner TryGetSummoner(string ConnectionId)
        {
            Summoner foundItem;
            ClientSummoner.TryGetValue(ConnectionId, out foundItem);
            return foundItem;
        }

        public static void TryRemoveSummoner(string ConnectionId)
        {
            if (!ClientSummoner.ContainsKey(ConnectionId)) return;
            ClientSummoner[ConnectionId] = null;
            ClientSummoner.Remove(ConnectionId);
        }
        #endregion
    }
}