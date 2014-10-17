namespace AirlinesDemo.Repositories.Entities
{
    using System.Collections.Generic;

    public class Customer : User
    {
        public string Address { get; set; }

        public List<Order> Orders { get; set; } 
    }
}