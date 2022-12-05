using System;
namespace TrendMachineAPI.Models
{
    public class GameInfo
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Peak_Num { get; set; }
        public int Net_Income { get; set; }
    }
}
