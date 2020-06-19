using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class MatchDTO {

        #region [Attributes]
        public long gameId { get; set; }                                        //
        public List<ParticipantIdentityDTO> participantIdentities { get; set; } // Participant identity information.
        public int queueId { get; set; }                                        // Please refer to the Game Constants documentation.
        public string gameType { get; set; }                                    // Please refer to the Game Constants documentation.
        public long gameDuration { get; set; }                                  // Match duration in seconds.
        public List<TeamStatsDTO> teams { get; set; }                           // Team information.
        public string platformId { get; set; }                                  // Platform where the match was played.
        public long gameCreation { get; set; }                                  // Designates the timestamp when champion select ended and the loading screen appeared, NOT when the game timer was at 0:00.
        public int seasonId { get; set; }                                       // Please refer to the Game Constants documentation.
        public string gameVersion { get; set; }                                 // The major.minor version typically indicates the patch the match was played on.
        public int mapId { get; set; }                                          // Please refer to the Game Constants documentation.
        public string gameMode { get; set; }                                    // Please refer to the Game Constants documentation.
        public List<ParticipantDTO> participants { get; set; }                  // Participant information.
        #endregion
    }
}