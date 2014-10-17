namespace AirlinesDemo.Repositories.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces;

    [Table("Flights")]
    public class Flight : BaseEntity<int>, IObjectWithState
    {
        public string Description { get; set; }

        public int DepartureAirportId { get; set; }

        public int ArrivalAirportId { get; set; }

        public int AviacompanyId { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        public List<PassangersInFlight> PassangersInFlights { get; set; }

        [NotMapped]
        public State State { get; set; }
    }
}