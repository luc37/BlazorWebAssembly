using BlazorWebAssembly.Models.SourceApiModels;

namespace BlazorWebAssembly.Services.Api.Interfaces
{
    public interface IPokemonApiService
    {
        public Task<List<PokemonApiModel>> ListPokemon(string apiUrl);
        public Task<PokemonApiModel> GetPokemonDetails(string apiUrl);
    }
}
