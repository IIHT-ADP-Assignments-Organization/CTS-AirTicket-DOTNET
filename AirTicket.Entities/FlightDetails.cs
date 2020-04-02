using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Entities
{
   public class FlightDetails
    {
        public virtual string FlieghtNumber { get; set; }
        public virtual string From_Location { get; set; }
        public virtual string To_Location { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual DateTime DepartureDate { get; set; }
      
        public virtual int SeatToBook { get; set; }
        public virtual string Fare { get; set; }
    }
}
