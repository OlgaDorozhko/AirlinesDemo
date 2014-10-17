namespace AirlinesDemo.Repositories.Entities
{
    using System.Collections.Generic;

    public class Order : BaseEntity<int>
    {
        public int CustomerId { get; set; }

        public int FlightId { get; set; }

        public decimal Price { get; set; }

        // TODO: add table for currency
        public string CurrencyCode { get; set; }

        public List<PassangersInOrder> Passangers { get; set; } 
    }
}