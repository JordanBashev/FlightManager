using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Data.Models
{
    public class Users
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string FamilyName { get; set; }

        public long PIN { get; set; }

        public string Address { get; set; }

        public int TelephoneNumber { get; set; }

        public string Role { get; set; }
    }
}
