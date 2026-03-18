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

        public async Task<List<PropertyBlazorWASM.Models.Property>> GetProperties()
        {
            return await _http.GetFromJsonAsync<List<PropertyBlazorWASM.Models.Property>>("api/properties");
        }

        public async Task<PropertyBlazorWASM.Models.Property> GetProperty(int id)
        {
            return await _http.GetFromJsonAsync<PropertyBlazorWASM.Models.Property>($"api/properties/{id}");
        }

        public async Task CreateProperty(PropertyBlazorWASM.Models.Property property)
        {
            await _http.PostAsJsonAsync("api/properties", property);
        }

        public async Task UpdateProperty(PropertyBlazorWASM.Models.Property property)
        {
            await _http.PutAsJsonAsync($"api/properties/{property.PropertyID}", property);
        }

        public async Task DeleteProperty(int id)
        {
            await _http.DeleteAsync($"api/properties/{id}");
        }
    }

}
