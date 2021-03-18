using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Data.Models
{
    public class Reservation
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FamilyName { get; set; }

        public long PIN { get; set; }

        public long TelephoneNumber { get; set; }

        public string Nationality { get; set; }

        public string TicketType { get; set; }
    }
}
