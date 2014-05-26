namespace AirlinesDemo.Repositories.Entities
{
    using System.Data.Entity;

    public class EFDbContext: DbContext
    {
        public DbSet<Flight> Flights { get; set; } 
    }
}
