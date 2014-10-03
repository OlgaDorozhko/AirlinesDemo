namespace AirlinesDemo.Repositories.Entities
{
    using System.Data.Entity;

    public class FlightsContext: BaseContext<FlightsContext>
    {
        public DbSet<Flight> Flights { get; set; } 
    }
}
