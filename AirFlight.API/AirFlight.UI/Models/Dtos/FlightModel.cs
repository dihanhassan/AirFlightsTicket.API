namespace AirFlight.UI.Models.Flight
{
    public class FlightModel
    {
        public FlightModel()
        {
            TaxBreakDowns = new List<TaxBreakDown>();
        }
        public int Id { get; set; } 
        public decimal BasePrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Origin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public List<TaxBreakDown> TaxBreakDowns { get; set; }
    }
}
