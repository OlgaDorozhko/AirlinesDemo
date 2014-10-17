namespace AirlinesDemo.Controllers.WebApi
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Services.Entities;
    using Services.Interfaces;

    public class FlightController : ApiController
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        public string Get(int id)
        {
            return "value";
        }

        public string GetAll()
        {
            List<Flight> flights = _flightService.GetAll();

            return string.Empty;
        }
        
        public void Update(Flight flight)
        {
        }
    }
}