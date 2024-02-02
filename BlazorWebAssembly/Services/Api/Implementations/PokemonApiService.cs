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

        public async Task<T> GetSourceApiModelDetails<T>(string apiUrl) where T : class, new()
        {
            T? item = await _apiService.InvokeApiRequestGetAsync<T>(apiUrl);
            return item;
        }

        public async Task<List<T>> GetListSourceApiModelDetails<T>(List<LookUpApiModel> lookUps) where T : class, new()
        {
            var result = new List<T>();

            for(int i = 0; i < lookUps.Count; i++)
            {
                T? item = await _apiService.InvokeApiRequestGetAsync<T>(lookUps[i].Url);
                result.Add(item);
            }

            return result;
        }
    }
}
