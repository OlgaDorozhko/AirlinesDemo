namespace AirlinesDemo.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Interfaces;

    public class FlightRepository: IFlightRepository
    {
        private EFDbContext context;

        public FlightRepository()
        {
            context = new EFDbContext();
        }

        public List<Flight> GetAll()
        {
            return context.Flights.ToList();
        }
    }
}
