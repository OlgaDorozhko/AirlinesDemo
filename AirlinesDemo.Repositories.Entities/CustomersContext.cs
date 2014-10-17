namespace AirlinesDemo.Repositories.Entities
{
    using System.Data.Entity;

    public class CustomersContext : BaseContext<CustomersContext>
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<PassangersInOrder> PassangersInOrders { get; set; }

        public DbSet<Passanger> Passangers { get; set; }
    }
}
