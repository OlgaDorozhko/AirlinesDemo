namespace AirlinesDemo.Services.Interfaces
{
    using System.Collections.Generic;
    using Entities;

    public interface IFlightService
    {
        List<Flight> GetAll();

        void Update(Flight flight);
    }
}
