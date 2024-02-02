using BlazorWebAssembly.Models.SourceApiModels;

namespace BlazorWebAssembly.Services.Api.Interfaces
{
    public interface IPokemonApiService
    {
        Task<ListResponseApiModel<PokemonApiModel>> ListPokemon(string apiUrl);
        Task<T> GetSourceApiModelDetails<T>(string apiUrl) where T : class, new();
        Task<List<T>> GetListSourceApiModelDetails<T>(List<LookUpApiModel> lookUps) where T : class, new();
    }
}
