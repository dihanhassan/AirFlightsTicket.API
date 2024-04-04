namespace AirFlight.UI.Models.Flight
{
    public class FlightByRoutes
    {
        public FlightByRoutes()
        {
            DirectionWiseFlight = new List<List<FlightModel>>();

            DirectionWiseFlight.Add(new List<FlightModel>()
            {
                new FlightModel
                {
                    Id = 1,
                    BasePrice = 100,
                    TaxPrice = 10,
                    TotalPrice = 110,
                    Origin = "Jashore",
                    Destination = "Dhaka",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 1,
                    BasePrice = 200,
                    TaxPrice = 10,
                    TotalPrice = 210,
                    Origin = "Jashore",
                    Destination = "Dhaka",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 1,
                    BasePrice = 300,
                    TaxPrice = 10,
                    TotalPrice = 310,
                    Origin = "Jashore",
                    Destination = "Dhaka",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                }
            });

                DirectionWiseFlight.Add(new List<FlightModel>()
            {
                new FlightModel
                {
                    Id = 2,
                    BasePrice = 100,
                    TaxPrice = 10,
                    TotalPrice = 110,
                    Origin = "Dhaka",
                    Destination = "Chittagong",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 2,
                    BasePrice = 200,
                    TaxPrice = 10,
                    TotalPrice = 210,
                    Origin = "Dhaka",
                    Destination = "Chittagong",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 2,
                    BasePrice = 300,
                    TaxPrice = 10,
                    TotalPrice = 310,
                    Origin = "Dhaka",
                    Destination = "Chittagong",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                }
            });

                DirectionWiseFlight.Add(new List<FlightModel>()
            {
                new FlightModel
                {
                    Id = 3,
                    BasePrice = 100,
                    TaxPrice = 10,
                    TotalPrice = 110,
                    Origin = "Chittagong",
                    Destination = "Jashore",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 3,
                    BasePrice = 200,
                    TaxPrice = 10,
                    TotalPrice = 210,
                    Origin = "Chittagong",
                    Destination = "Jashore",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                },
                new FlightModel
                {
                    Id = 3,
                    BasePrice = 300,
                    TaxPrice = 10,
                    TotalPrice = 310,
                    Origin = "Chittagong",
                    Destination = "Jashore",
                    TaxBreakDowns = new List<TaxBreakDown>()
                    {
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "VAT"
                        },
                        new TaxBreakDown
                        {
                            Tax = 5,
                            Description = "Service Charge"
                        }
                    }
                }
            });
        }
        public List<List<FlightModel>> DirectionWiseFlight { get; set; }
    }
}
