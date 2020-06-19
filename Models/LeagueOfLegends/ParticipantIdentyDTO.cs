using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class ParticipantIdentityDTO {

        #region [Attributes]
        public int participantId { get; set; }
        public PlayerDTO player	 { get; set; } //Player information not included in the response for custom matches. Custom matches are considered private unless a tournament code was used to create the match.
        #endregion
    }
}