using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class MatchlistDTO {

        #region [Attributes]
        public int startIndex { get; set; }
        public int totalGames { get; set; }
        public int endIndex { get; set; }
        public List<MatchReferenceDTO> matches { get; set; }
        #endregion
    }
}