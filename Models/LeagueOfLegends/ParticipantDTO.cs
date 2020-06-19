using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class ParticipantIdentityDTO {

        #region [Attributes]
        public int participantId { get; set; } // 
        public int championId { get; set; } // 
        public List<RuneDTO> runes { get; set; } // List of legacy Rune information. Not included for matches played with Runes Reforged.
        public ParticipantStatsDTO stats { get; set; } // Participant statistics.
        public int teamId { get; set; } // 100 for blue side. 200 for red side.
        public ParticipantTimelineDTO timeline { get; set; } // Participant timeline data.
        public int spell1Id { get; set; } // First Summoner Spell id.
        public int spell2Id { get; set; } // Second Summoner Spell id.
        public string highestAchievedSeasonTier { get; set; } // Highest ranked tier achieved for the previous season in a specific subset of queueIds, if any, otherwise null. Used to display border in game loading screen. Please refer to the Ranked Info documentation. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)
        public List<MasteryDTO> masteries { get; set; } // List of legacy Mastery information. Not included for matches played with Runes Reforged.
        #endregion
    }
}