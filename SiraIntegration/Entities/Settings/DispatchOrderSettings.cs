namespace SiraIntegration.Entities
{
    public class DispatchOrderSettings
    {
        public int PostOrderInterval { get; set; }
        public string PostOrderUnit { get; set; }
        public int ReviewOrderInterval { get; set; }
        public string ReviewOrderUnit { get; set; }
      
        public int OrdersCount { get; set; }
        public int ReviewsCount { get; set; }
    }
}

