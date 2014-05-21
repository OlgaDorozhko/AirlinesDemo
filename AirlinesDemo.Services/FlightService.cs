namespace AirlinesDemo.Services
{
    using System.Collections.Generic;
    using AutoMapper;
    using Entities;
    using Interfaces;
    using Repositories.Interfaces;
    using DBEntities = Repositories.Entities;

    public class FlightService: IFlightService
    {
        private readonly IFlightRepository _flightService;

        public FlightService(IFlightRepository flightService)
        {
            _flightService = flightService;
        }

        public List<Flight> GetAll()
        {
            List<DBEntities.Flight> flights = _flightService.GetAll();

            return Mapper.Map<List<DBEntities.Flight>, List<Flight>>(flights);
        }
    }
}
