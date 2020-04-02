using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Entities
{
   public class Invoice
    {
        public virtual string InvoiceId { get; set; }
        public virtual string Customername { get; set; }
        public virtual string BookingId { get; set; }
        public virtual string Airlinename { get; set; }
        public virtual string LeavingFrom { get; set; }
        public virtual string GoingTo { get; set; }
        public virtual int Numberofpassengers { get; set; }
        public virtual DateTime DateOfJourney { get; set; }
        public virtual DateTime DepartureTime { get; set; }
        public virtual DateTime BookingDate { get; set; }
        public virtual long TotalPrice { get; set; }
      
    }
}
