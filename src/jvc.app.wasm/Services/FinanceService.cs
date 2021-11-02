using System.Net.Http;
using System.Threading.Tasks;

namespace jvc.app.wasm.Services
{
    public class FinanceService : IFinanceService
    {
        HttpClient _httpClient;

        public FinanceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetStatusAsync()
        {
            return await _httpClient.GetStringAsync("/api/finance/status");
        }
    }
}
