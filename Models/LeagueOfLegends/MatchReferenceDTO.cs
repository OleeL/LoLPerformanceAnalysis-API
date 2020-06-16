namespace LoLPerformanceAnalysisAPI.Models
{
    public class MatchReferenceDTO
    {
        #region [Attributes]
        public long gameId { get; set; }
        public string role { get; set; }
        public int season { get; set; }
        public string platformId { get; set; }
        public int champion { get; set; }
        public int queue { get; set; }
        public string lane { get; set; }
        public long timestamp { get; set; }
        #endregion
    }
}