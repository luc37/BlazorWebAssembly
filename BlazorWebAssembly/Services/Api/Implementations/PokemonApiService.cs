using BlazorWebAssembly.Models.SourceApiModels;
using BlazorWebAssembly.Services.Api.Interfaces;

namespace BlazorWebAssembly.Services.Api.Implementations
{
    public class PokemonApiService(IApiService apiService) : IPokemonApiService
    {
        private readonly IApiService _apiService = apiService ?? throw new ArgumentNullException(nameof(IApiService));

        public async Task<List<PokemonApiModel>> ListPokemon(string apiUrl)
        {
            var sourcePokemonList = new List<PokemonApiModel>();
            var response = await _apiService.InvokeApiRequestGetAsync<ListResponseApiModel<PokemonApiModel>>(apiUrl);

            if (response != null)
                sourcePokemonList = response.Results.ToList();

            return sourcePokemonList;
        }

        public async Task<PokemonApiModel> GetPokemonDetails(string apiUrl)
        {
            PokemonApiModel? sourcePokemon = await _apiService.InvokeApiRequestGetAsync<PokemonApiModel>(apiUrl);
            return sourcePokemon;
        }
    }
}
