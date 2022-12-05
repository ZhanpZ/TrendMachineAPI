namespace TrendMachineAPI.Models
{
    public class GamePurchase
    {
        public int game_id { get; set; }
        public int transaction_id { get; set; }
        public int user_id { get; set; }
        public string purchase_date { get; set; }
        public int purchase_price { get; set; }
        public string purchase_method { get; set; }
    }
}
