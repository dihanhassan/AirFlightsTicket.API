namespace AirFlight.UI.Models.Response
{
    public class Response
    {
        public string? StatusCode { get; set; } = string.Empty;
        string ? Message { get; set; } = string.Empty;

        public dynamic? Data { get; set; }

    }
}
