using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.Entities
{
   public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Gender { get; set; }
        public virtual string SSNType { get; set; }
        public virtual string SSNNumber { get; set; }
    }
}
