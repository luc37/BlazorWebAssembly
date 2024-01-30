namespace BlazorWebAssembly.Services.Api.Interfaces
{
    public interface IApiService
    {
        Task<T> InvokeApiRequestGetAsync<T>(string url) where T : class, new();
    }
}
