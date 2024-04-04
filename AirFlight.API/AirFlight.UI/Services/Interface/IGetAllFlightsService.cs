using AirFlight.UI.Models.Response;

namespace AirFlight.UI.Services.Interface
{
    public interface IGetAllFlightsService
    {
       public  Task<Response> GetAllFlights();
    }
}
