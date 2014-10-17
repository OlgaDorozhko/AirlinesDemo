namespace AirlinesDemo.Repositories
{
    using System.Data.Entity;
    using System.Linq;
    using DAL;
    using Entities;
    using Interfaces;

    public class CustomerRepository : ICustomerRepository
    {
        private CustomersContext context;

        public CustomerRepository(IUnitOfWork unitOfWork)
        {
           // context = unitOfWork.Context;
        }

        public Customer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Add(Customer entity)
        {
            context.Entry(entity).State = EntityState.Added;
        }
        
        public void AddGraph(Customer entity)
        {
            context.Customers.Add(entity);
        }

        public void Update(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
