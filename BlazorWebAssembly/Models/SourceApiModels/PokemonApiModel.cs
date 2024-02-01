namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class PokemonApiModel : BaseApiModel
    {
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public SpriteApiModel Sprites { get; set; }
        public SpeciesLookUpApiModel Species { get; set; }
    }
}
