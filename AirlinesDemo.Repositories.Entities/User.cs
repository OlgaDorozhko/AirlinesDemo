namespace AirlinesDemo.Repositories.Entities
{
    public abstract class User : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Passport { get; set; }
    }
}
