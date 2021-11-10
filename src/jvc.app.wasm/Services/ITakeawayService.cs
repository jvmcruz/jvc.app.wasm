using jvc.app.wasm.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jvc.app.wasm.Services
{
    public interface ITakeawayService
    {
        Task<string> GetStatus();
        Task<List<TakeawayDto>> GetTakeaways();
    }
}
