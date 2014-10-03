using System.ComponentModel.DataAnnotations;

namespace AirlinesDemo.Repositories.Entities
{
    using System;

    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public static string Serialize()
        {
            // TODO: provide serializing
            return string.Empty;
        }
    }
}
