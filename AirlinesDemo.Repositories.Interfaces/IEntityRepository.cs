using System.Linq;

namespace AirlinesDemo.Repositories.Interfaces
{
    public interface IEntityRepository<T>
    {
        T Get(int id);

        IQueryable<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
