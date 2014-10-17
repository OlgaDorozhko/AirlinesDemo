namespace AirlinesDemo.Repositories.Entities
{
    using System.Data.Entity;

    public class FlightsContext: BaseContext<FlightsContext>
    {
        public DbSet<Flight> Flights { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Airline> Airlines { get; set; }
    }
}
