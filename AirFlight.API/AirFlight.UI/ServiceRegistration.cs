using AirFlight.UI.Models.Connection;
using Microsoft.Extensions.DependencyInjection;
using AirFlight.UI.Services.Interface;
using AirFlight.UI.Services.Implementation;

namespace AirFlight.UI
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<DapperDBConnection>();
            services.AddTransient<IGetAllFlightsService, GetAllFlightsService>();
            // Add more service registrations here as needed
        }
    }
}
