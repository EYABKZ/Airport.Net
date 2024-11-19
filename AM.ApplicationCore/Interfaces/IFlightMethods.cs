using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    internal interface IFlightMethods
    {
        // Signature des méthodes requises dans FlightMethods

        List<Flight> GetAllFlights();
        Flight GetFlightById(int id);
        void AddFlight(Flight flight);
        bool RemoveFlight(int id);
    }
}
