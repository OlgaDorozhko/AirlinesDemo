namespace AirlinesDemo.Repositories
{
    using System.Linq;
    using DAL;
    using Entities;
    using Interfaces;

    public class FlightRepository: IFlightRepository
    {
        private FlightsContext context;

        public FlightRepository(IUnitOfWork unitOfWork)
        {
            context = unitOfWork.Context;
        }

        public Flight Get(int id)
        {
            return context.Flights.Find(id);
        }

        public IQueryable<Flight> GetAll()
        {
            return context.Flights;
        }

        public void Add(Flight flight)
        {
            context.Flights.Add(flight);
        }
        
        public void Update(Flight flight)
        {
            context.Flights.Add(flight);
            context.Entry(flight).State = StateHelper.ConvertState(flight.State);
        }
        
        public void Delete(int id)
        {
            var flight = context.Flights.Find(id);
            context.Flights.Remove(flight);
        }
    }
}
