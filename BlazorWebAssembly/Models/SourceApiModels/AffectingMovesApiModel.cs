namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class AffectingMovesApiModel
    {
        public List<IncreaseApiModel> Increase { get; set; }
        public List<DecreaseApiModel> Decrease { get; set; }
    }
}
