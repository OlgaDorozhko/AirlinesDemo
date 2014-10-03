using System.Data.Entity;

namespace AirlinesDemo.Repositories.Entities
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext()
            : base("name=FlightsDatabase")
        {
        } 
    }
}
