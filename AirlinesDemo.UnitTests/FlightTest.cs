namespace AirlinesDemo.UnitTests
{
    using System.Collections.Generic;
    using AutoMapper;
    using Moq;
    using NUnit.Framework;
    using Repositories.Interfaces;
    using Services;
    using Services.Entities;
    using Assert = NUnit.Framework.Assert;

    [TestFixture]
    public class FlightTest
    {
        private List<Repositories.Entities.Flight> testFlights;
            
        [TestFixtureSetUp]
        public void Initialize()
        {
            SetMappings();
            SetListOfFlights();
        }

        private void SetListOfFlights()
        {
            testFlights = new List<Repositories.Entities.Flight>
                {
                    new Repositories.Entities.Flight
                        {
                            Id = 1,
                            Description = "First flight"
                        },
                    new Repositories.Entities.Flight
                        {
                            Id = 2,
                            Description = "Second flight"
                        }
                };
        }

        private static void SetMappings()
        {
            Mapper.CreateMap<Flight, Repositories.Entities.Flight>();
            Mapper.CreateMap<Repositories.Entities.Flight, Flight>();
        }

        [Test]
        public void GetAllFlights_Empty_ListOfFlights()
        {
            Mock<IFlightRepository> repositoryMock = new Mock<IFlightRepository>();
            repositoryMock.Setup(m => m.GetAll()).Returns(testFlights);
            FlightService service = new FlightService(repositoryMock.Object);

            List<Flight> flights = service.GetAll();

            Assert.AreEqual(flights.Count, testFlights.Count);
        }
    }
}
