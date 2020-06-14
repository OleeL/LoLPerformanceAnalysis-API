using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class Summoner {
        #region Static Attributes
        public static Dictionary<string, Summoner> ClientSummoner = new Dictionary<string, Summoner>();
        public static bool ClientSummonerExists(string id) => ClientSummoner.ContainsKey(id) && ClientSummoner[id] != null;
        #endregion

        #region Attributes
        public string accountId { get; set; }   // Encrypted account ID. Max length 56 characters.
        public int profileIconId { get; set; }  // ID of the summoner icon associated with the summoner.
        public long revisionDate { get; set; }  // summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        public string name { get; set; }        // Summoner name.
        public string id { get; set; }          // Encrypted summoner ID. Max length 63 characters.
        public string puuid { get; set; }       // Encrypted PUUID. Exact length of 78 characters.
        public long summonerLevel { get; set; } // Summoner level associated with the summoner.
        #endregion
        
        #region Static methods
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