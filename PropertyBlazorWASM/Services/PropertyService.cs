using PropertyBlazorWASM.Models;
using System.Net.Http.Json;

namespace PropertyBlazorWASM.Services
{
    public class PropertyService
    {
        private readonly HttpClient _http;

        public PropertyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Property>> GetProperties()
        {
            return await _http.GetFromJsonAsync<List<Property>>("api/properties");
        }

        public async Task<Property> GetProperty(int id)
        {
            return await _http.GetFromJsonAsync<Property>($"api/properties/{id}");
        }

        public async Task CreateProperty(Property property)
        {
            await _http.PostAsJsonAsync("api/properties", property);
        }

        public async Task UpdateProperty(Property property)
        {
            await _http.PutAsJsonAsync($"api/properties/{property.PropertyID}", property);
        }

        public async Task DeleteProperty(int id)
        {
            await _http.DeleteAsync($"api/properties/{id}");
        }
    }

}
