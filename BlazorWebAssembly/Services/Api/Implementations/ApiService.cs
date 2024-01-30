using BlazorWebAssembly.Services.Api.Interfaces;
using Newtonsoft.Json;

namespace BlazorWebAssembly.Services.Api.Implementations
{
    public class ApiService(HttpClient httpClient) : IApiService
    {
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(HttpClient));

        public async Task<T> InvokeApiRequestGetAsync<T>(string url) where T : class, new()
        {
            T result = new T();
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                T? data =JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

                if (data != null)
                    result = data;
            }

            return result;
        }
    }
}
