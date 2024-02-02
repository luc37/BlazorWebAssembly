namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class StatApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Is_battle_only { get; set; }
        public AffectingMovesApiModel Affecting_moves { get; set; }
        public AffectingNaturesApiModel Affecting_natures { get; set; }
        public List<LookUpApiModel> Characteristics { get; set; }
    }
}
