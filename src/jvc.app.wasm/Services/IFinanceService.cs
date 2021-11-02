using System.Threading.Tasks;

namespace jvc.app.wasm.Services
{
    public interface IFinanceService
    {
        Task<string> GetStatusAsync();
    }
}
