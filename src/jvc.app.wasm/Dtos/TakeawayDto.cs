using System.ComponentModel.DataAnnotations;

namespace jvc.app.wasm.Dtos
{
    public class TakeawayDto
    {
        [Required]
        public string Name { get; set; }
    }
}
