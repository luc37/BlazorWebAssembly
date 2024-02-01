namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class SpeciesApiModel
    {
        public int Base_happiness {  get; set; }
        public int Capture_rate { get; set; }
        public List<FlavorTextEntryApiModel> Flavor_text_entries { get; set; }
    }
}
