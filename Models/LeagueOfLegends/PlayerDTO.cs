using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class PlayerDTO {

        #region [Attributes]
        public int profileIcon { get; set; }  
        public string accountId { get; set; } // Player's original accountId (Encrypted)
        public string matchHistoryUri { get; set; } 
        public string currentAccountId { get; set; } // Player's current accountId (Encrypted)
        public string currentPlatformId { get; set; }
        public string summonerName { get; set; }
        public string summonerId { get; set; } // Player's summonerId (Encrypted)
        public string platformId { get; set; } // Original platformId.
        #endregion
    }
}