namespace AirlinesDemo.Repositories.Entities
{
    public class Airport : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}