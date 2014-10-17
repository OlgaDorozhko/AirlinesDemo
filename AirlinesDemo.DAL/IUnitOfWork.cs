namespace AirlinesDemo.DAL
{
    using Repositories.Entities;

    public interface IUnitOfWork
    {
        int Save();

        FlightsContext Context { get; }
    }
}