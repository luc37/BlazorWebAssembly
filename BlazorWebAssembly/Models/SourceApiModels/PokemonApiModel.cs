namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class PokemonApiModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public SpriteApiModel Sprites { get; set; }
    }
}
