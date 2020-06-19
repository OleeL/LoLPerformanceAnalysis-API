using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class TeamBansDTO {

        #region [Attributes]
        public int championId { get; set; } //Banned championId.
        public int pickTurn { get; set; }   //Turn during which the champion was banned.
        #endregion
    }
}