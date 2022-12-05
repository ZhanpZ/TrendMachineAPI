
namespace TrendMachineAPI.Models
{
    public class GameTrendResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public GameInfo?GameInfo { get; set; }
        public List<GameInfo?> gametrend { get; set; }
    }
}
