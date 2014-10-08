using System.Linq;
using AirlinesDemo.Repositories.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirlinesDemo.Repositories.UnitTests
{
    [TestClass]
    public class ContextsTests
    {
        [TestMethod]
        public void CouldFligthBeInsertedToDb()
        {
            using (var context = new FlightsContext())
            {
                context.Flights.Add(new Flight
                {
                    Id = 1,
                    Description = "Main flight"
                });

                context.SaveChanges();
            }

            using (var context = new FlightsContext())
            {
                Assert.IsNotNull(context.Flights.FirstOrDefault());
                Assert.IsTrue(context.Flights.FirstOrDefault().Id == 1);
            }
        }
    }
}
