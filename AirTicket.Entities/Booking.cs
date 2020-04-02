using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Entities
{
   public class Booking
    {
        public virtual string BookingId { get; set; }
        public virtual string LeavingFrom { get; set; }
        public virtual string GoingTo { get; set; }
       
        
        public virtual long NumberOfPassengers { get; set; }
        public virtual string Password { get; set; }
        public virtual int CustomerId  { get; set; }
    }
}
