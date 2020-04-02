using AirTicket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicket.BusinessLayer.Interfaces
{
    public interface ICustomerServices
    {
        bool RegisterCustomer(Customer customer);
        FlightDetails Searchflight(string From_Location, string To_Location, DateTime StartTime, DateTime DepartureDate, int SeatToBook);
        bool TicketBooking(Booking booking);
        bool EditProfile(Customer customer);
        bool CancelTicket(string BookingId);

        Customer GetCustomerById(int CustomerId);
        FlightDetails GetFlightDetails(string From_Location, string To_Location, DateTime StartTime, DateTime DepartureDate, int SeatToBook);
    }
}
