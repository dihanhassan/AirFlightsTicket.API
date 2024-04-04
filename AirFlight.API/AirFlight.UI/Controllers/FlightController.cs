using AirFlight.UI.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirFlight.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
       
        private readonly IGetAllFlightsService _getAllFlightsService;
        public FlightController(IGetAllFlightsService getAllFlightsService)
        {
            _getAllFlightsService = getAllFlightsService;
        }
        [HttpGet]
        [Route("GetAllFlights")]
        public async Task<IActionResult> GetAllFlights()
        {
            return Ok(_getAllFlightsService.GetAllFlights());
        }
    }
}
