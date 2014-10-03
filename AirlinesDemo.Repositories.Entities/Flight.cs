using System.ComponentModel.DataAnnotations.Schema;

namespace AirlinesDemo.Repositories.Entities
{
    [Table("Flights")]
    public class Flight: BaseEntity<int>
    {
        public string Description { get; set; }
    }
}
