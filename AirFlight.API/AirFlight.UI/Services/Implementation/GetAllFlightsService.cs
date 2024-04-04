using AirFlight.UI.Models.Flight;
using AirFlight.UI.Models.Response;
using AirFlight.UI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirFlight.UI.Services.Implementation
{
    public class GetAllFlightsService : IGetAllFlightsService
    {
        public async Task<Response> GetAllFlights()
        {
            try
            {
                Response response = new Response();
                response.StatusCode = "200";
                List<FlightResponseModel> flightResponseModels = new List<FlightResponseModel>();

                FlightByRoutes flightByRoutes = new FlightByRoutes();

                GenerateCombinations(flightByRoutes.DirectionWiseFlight, new List<FlightModel>(), flightResponseModels);

                response.Data = flightResponseModels;
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void GenerateCombinations(List<List<FlightModel>> directionWiseFlights, List<FlightModel> currentCombination, List<FlightResponseModel> flightResponseModels)
        {
            if (currentCombination.Count == directionWiseFlights.Count)
            {
                // Base case: All legs of the journey have been chosen
                AddFlightCombinationToResults(currentCombination, flightResponseModels);
                return;
            }

            foreach (var flight in directionWiseFlights[currentCombination.Count])
            {
                // Choose a flight for the current leg
                currentCombination.Add(flight);
                // Recur to the next leg
                GenerateCombinations(directionWiseFlights, currentCombination, flightResponseModels);
                // Backtrack: Remove the chosen flight for backtracking
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        private void AddFlightCombinationToResults(List<FlightModel> combination, List<FlightResponseModel> flightResponseModels)
        {
            // Construct FlightResponseModel for the current combination
            FlightResponseModel flightResponseModel = new FlightResponseModel();
            decimal totalBasePrice = 0;
            decimal totalTaxPrice = 0;
            decimal totalPrice = 0;
            List<FlightDetails> flightDetails = new List<FlightDetails>();
            List<TaxBreakDown> taxBreakDowns = new List<TaxBreakDown>();

            foreach (var flight in combination)
            {
                totalBasePrice += flight.BasePrice;
                totalTaxPrice += flight.TaxPrice;
                totalPrice += flight.TotalPrice;
                flightDetails.Add(new FlightDetails
                {
                    Id = flight.Id,
                    BasePrice = flight.BasePrice,
                    TaxPrice = flight.TaxPrice,
                    TotalPrice = flight.TotalPrice,
                    Origin = flight.Origin,
                    Destination = flight.Destination
                });
                taxBreakDowns.AddRange(flight.TaxBreakDowns);
            }

            flightResponseModel.TotalBasePrice = totalBasePrice;
            flightResponseModel.TotalTaxPrice = totalTaxPrice;
            flightResponseModel.TotalPrice = totalPrice;
            flightResponseModel.Flights = flightDetails;
            flightResponseModel.TaxBreakDowns = taxBreakDowns;

            flightResponseModels.Add(flightResponseModel);
        }
    }
}
