using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Test.Exceptions
{
  public  class CustomercannotEmptyException:Exception
    {
        public string Messages = "Customer Not Found";

        public CustomercannotEmptyException(string message)
        {
            Messages = message;
        }
    }
}
