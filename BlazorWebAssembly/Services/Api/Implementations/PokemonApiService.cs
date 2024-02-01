using BlazorWebAssembly.Models.SourceApiModels;
using BlazorWebAssembly.Services.Api.Interfaces;

namespace BlazorWebAssembly.Services.Api.Implementations
{
    public class PokemonApiService(IApiService apiService) : IPokemonApiService
    {
        private readonly IApiService _apiService = apiService ?? throw new ArgumentNullException(nameof(IApiService));

        public async Task<ListResponseApiModel<PokemonApiModel>> ListPokemon(string apiUrl)
        {
            var response = await _apiService.InvokeApiRequestGetAsync<ListResponseApiModel<PokemonApiModel>>(apiUrl);
            return response;
        }

        public async Task<PokemonApiModel> GetPokemonDetails(string apiUrl)
        {
            PokemonApiModel? sourcePokemon = await _apiService.InvokeApiRequestGetAsync<PokemonApiModel>(apiUrl);
            return sourcePokemon;
        }

        public async Task<SpeciesApiModel> GetSpeciesDetails(string apiUrl)
        {
            SpeciesApiModel? sourceSpecies = await _apiService.InvokeApiRequestGetAsync<SpeciesApiModel>(apiUrl);
            return sourceSpecies;
        }
    }
}
