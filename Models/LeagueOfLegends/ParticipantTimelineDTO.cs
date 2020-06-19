using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class ParticipantTimelineDTO {

        #region [Attributes]
        public int participantId { get; set; }
        public Dictionary<string, double> csDiffPerMinDeltas { get; set; }          // Creep score difference versus the calculated lane opponent(s) for a specified period.
        public Dictionary<string, double> damageTakenPerMinDeltas { get; set; }     // Damage taken for a specified period.
        public string role { get; set; }                                            // Role Participant's calculated role. (Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        public Dictionary<string, double> damageTakenDiffPerMinDeltas { get; set; } // Damage taken difference versus the calculated lane opponent(s) for a specified period.
        public Dictionary<string, double> xpPerMinDeltas { get; set; }              // Experience change for a specified period.
        public Dictionary<string, double> xpDiffPerMinDeltas { get; set; }          // Experience difference versus the calculated lane opponent(s) for a specified period.
        public string lane { get; set; }                                            // Lane Participant's calculated lane. MID and BOT are legacy values. (Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        public Dictionary<string, double> creepsPerMinDeltas { get; set; }          // Creeps for a specified period.
        public Dictionary<string, double> goldPerMinDeltas { get; set; }            // Gold for a specified period.
        #endregion
    }
}