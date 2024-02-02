namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class AbilityApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EffectEntryApiModel> Effect_entries { get; set; }
        public List<LookUpApiModel> Pokemon { get; set; }
    }
}
