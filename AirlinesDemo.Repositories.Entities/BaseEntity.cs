namespace AirlinesDemo.Repositories.Entities
{
    using System;

    public class BaseEntity<T>
    {
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
