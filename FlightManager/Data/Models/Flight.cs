using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Data.Models
{
    public class Flight
    {

        //Локация-от
        public string From { get; set; }


        //Локациа-за
        public string To { get; set; }

        //Време на излитане
        public DateTime DateTimeTakeOff { get; set; }


        //Продължителността на полета, а не време и дата на кацане.
        public DateTime DateTimeLanding { get; set; }

        //Типа на самолета
        public string PlaneType { get; set; }

        public int UniquePlaneNumber { get; set; }

        public string PilotName { get; set; }

        public int PassengersCapacity { get; set; }

        public int BusisnessClassCapacity { get; set; }
    }
}
