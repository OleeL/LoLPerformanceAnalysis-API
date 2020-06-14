using System.Collections.Generic;

namespace LoLPerformanceAnalysisAPI.Models {

    public class MiniSeriesDTO {

        #region Attributes
        public int losses { get; set; }
        public string progress { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
        #endregion
    }
}