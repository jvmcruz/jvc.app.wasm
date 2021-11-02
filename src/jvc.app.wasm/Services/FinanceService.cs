using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace jvc.app.wasm.Services
{
    public class FinanceService : IFinanceService
    {
        HttpClient _httpClient;

        public FinanceService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(configuration["BaseAddress"]);
        }

        public async Task<string> GetStatusAsync()
        {   
            return await _httpClient.GetStringAsync("/api/finance/status");
        }
    }
}
