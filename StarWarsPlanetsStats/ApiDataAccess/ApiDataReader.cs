

namespace StarWarsPlanetsStats.ApiDataAccess
{
    public class ApiDataReader : IApiDataReader
    {
        public async Task<string> Read(string baseAddress, string RequestUri)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            HttpResponseMessage response = await client.GetAsync(RequestUri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
