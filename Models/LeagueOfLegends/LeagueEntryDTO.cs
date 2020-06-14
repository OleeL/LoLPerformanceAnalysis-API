using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class LeagueEntryDTO {

        #region Attributes
        public string leagueId { get; set; }
        public string summonerId { get; set; }    //	Player's encrypted summonerId.
        public string summonerName { get; set; }
        public string queueType { get; set; }
        public string tier { get; set; }
        public string rank { get; set; }
        public int leaguePoints { get; set; }
        public int wins { get; set; }             //	Winning team on Summoners Rift.
        public int losses { get; set; }           //	Losing team on Summoners Rift.
        public bool hotStreak { get; set; }
        public bool veteran { get; set; }
        public bool freshBlood { get; set; }
        public bool inactive { get; set; }
        public MiniSeriesDTO? miniSeries { get; set; }   
        #endregion
    }
}