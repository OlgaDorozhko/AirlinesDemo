namespace AirlinesDemo.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using DAL;
    using Entities;
    using Interfaces;
    using Repositories.Interfaces;
    using DBEntities = Repositories.Entities;

    public class FlightService: IFlightService
    {
        private readonly IFlightRepository _flightService;

        public FlightService(IFlightRepository flightService, IUnitOfWork unitOfWork)
        {
            _flightService = flightService;
        }

        public List<Flight> GetAll()
        {
            List<DBEntities.Flight> flights = _flightService.GetAll().ToList();

            return Mapper.Map<List<DBEntities.Flight>, List<Flight>>(flights);
        }

        public void Update(Flight flight)
        {
            DBEntities.Flight dtoFlight = Mapper.Map<Flight, DBEntities.Flight>(flight);
            
            _flightService.Update(dtoFlight);
        }
    }
}
