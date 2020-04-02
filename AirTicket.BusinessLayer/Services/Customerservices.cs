using AirTicket.BusinessLayer.Interfaces;
using AirTicket.DataLayer.NHibernateConfiguration;
using AirTicket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.BusinessLayer.Services
{
  public  class Customerservices:ICustomerServices
    {
        private readonly IMapperSession _session;

        public Customerservices(IMapperSession session)
        {
            _session = session;
        }

        public bool CancelTicket(string BookingId)
        {
            return true;
        }

        public bool EditProfile(Customer customer)
        {
            return true;
        }

       

        public Customer GetCustomerById(int CustomerId)
        {
            Customer customer = new Customer();
            return customer;
        }

        public FlightDetails GetFlightDetails(string From_Location,string To_Location,DateTime StartTime,DateTime DepartureDate,int SeatToBook)
        {
            FlightDetails flightDetails = new FlightDetails();
            return flightDetails;
        }

        public bool RegisterCustomer(Customer customer)
        {
            return true;
        }

        public FlightDetails Searchflight(string From_Location, string To_Location, DateTime StartTime, DateTime DepartureDate, int SeatToBook)
        {
            FlightDetails flightDetails = new FlightDetails();
            return flightDetails;
        }

        public bool TicketBooking(Booking booking)
        {
            return true;
        }
    }
}
