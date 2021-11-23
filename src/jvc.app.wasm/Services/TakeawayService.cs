using jvc.app.wasm.Dtos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace jvc.app.wasm.Services
{
    public class TakeawayService : ITakeawayService
    {
        private const string Takeaways = "/api/values/takeaways";
        HttpClient _httpClient;

        public TakeawayService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(configuration["BaseAddress"]);
        }

        public async Task<string> GetStatus()
        {
            return await _httpClient.GetStringAsync("/api/values/status");
        }

        public async Task<List<TakeawayDto>> GetTakeaways()
        {
            return await _httpClient.GetFromJsonAsync<List<TakeawayDto>>(Takeaways);
        }

        public async Task<bool> AddTakeaway(TakeawayDto takeaway)
        {
            var response = await _httpClient.PostAsJsonAsync(Takeaways, takeaway);
            return response.IsSuccessStatusCode;
        }
    }
}
