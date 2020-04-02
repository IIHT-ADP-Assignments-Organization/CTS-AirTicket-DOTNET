using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Test.Exceptions
{
    public class CustomerNotFoundException:Exception
    {
        public string Messages = "Customer Not Found";

        public CustomerNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
