using BlazorWebAssembly.Models.SourceApiModels;

namespace BlazorWebAssembly.Models.ViewModels
{
    public class PokemonViewModel : PokemonApiModel
    {
        public string TileImageUrl { get; set; }
        public string FlavourText { get; set; }
    }
}
