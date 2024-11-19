using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class FlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        FlightMethods fm = new FlightMethods();
        fm.Flights = TestData.listFlights;


    }
}
