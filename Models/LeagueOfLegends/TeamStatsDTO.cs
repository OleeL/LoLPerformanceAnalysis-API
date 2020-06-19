using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class TeamStatsDTO {

        #region [Attributes]
        public int towerKills { get; set; }           //Number of towers the team destroyed.
        public int riftHeraldKills { get; set; }      //Number of times the team killed Rift Herald.
        public bool firstBlood { get; set; }       //Flag indicating whether or not the team scored the first blood.
        public int inhibitorKills { get; set; }       //Number of inhibitors the team destroyed.
        public List<TeamBansDTO> bans { get; set; }         // bans If match queueId has a draft, contains banned champion data, otherwise empty.
        public bool firstBaron { get; set; }       //Flag indicating whether or not the team scored the first Baron kill.
        public bool firstDragon { get; set; }      //Flag indicating whether or not the team scored the first Dragon kill.
        public int dominionVictoryScore { get; set; } //For Dominion matches, specifies the points the team had at game end.
        public int dragonKills { get; set; }          //Number of times the team killed Dragon.
        public int baronKills { get; set; }           //Number of times the team killed Baron.
        public bool firstInhibitor { get; set; }   //Flag indicating whether or not the team destroyed the first inhibitor.
        public bool firstTower { get; set; }       //Flag indicating whether or not the team destroyed the first tower.
        public int vilemawKills { get; set; }         //Number of times the team killed Vilemaw.
        public bool firstRiftHerald { get; set; }  //Flag indicating whether or not the team scored the first Rift Herald kill.
        public int teamId { get; set; }               //100 for blue side. 200 for red side.
        public string win { get; set; }               //String indicating whether or not the team won. There are only two values visibile in public match history. (Legal values: Fail, Win)
        #endregion
    }
}