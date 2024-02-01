using BlazorWebAssembly.Models.SourceApiModels;

namespace BlazorWebAssembly.Services.Api.Interfaces
{
    public interface IPokemonApiService
    {
        public Task<ListResponseApiModel<PokemonApiModel>> ListPokemon(string apiUrl);
        public Task<PokemonApiModel> GetPokemonDetails(string apiUrl);
        public Task<SpeciesApiModel> GetSpeciesDetails(string apiUrl);
    }
}
