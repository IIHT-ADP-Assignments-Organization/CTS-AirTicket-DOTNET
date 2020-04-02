using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Test.Exceptions
{
    public class FlightNotFoundException:Exception
    {
        public string Messages = "Flight Not Found ";

        public FlightNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
