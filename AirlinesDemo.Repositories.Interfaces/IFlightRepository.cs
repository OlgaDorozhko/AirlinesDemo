namespace AirlinesDemo.Repositories.Interfaces
{
    using System.Collections.Generic;
    using Entities;

    public interface IFlightRepository
    {
        List<Flight> GetAll();
    }
}
