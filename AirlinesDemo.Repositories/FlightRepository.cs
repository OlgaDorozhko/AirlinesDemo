namespace AirlinesDemo.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Interfaces;

    public class FlightRepository: IFlightRepository
    {
        private FlightsContext context;

        public FlightRepository()
        {
            context = new FlightsContext();
        }

        public List<Flight> GetAll()
        {
            return context.Flights.ToList();
        }
    }
}
