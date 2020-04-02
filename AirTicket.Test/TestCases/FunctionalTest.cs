using AirTicket.BusinessLayer.Services;
using AirTicket.DataLayer.NHibernateConfiguration;
using AirTicket.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AirTicket.Test.TestCases
{
   public class FunctionalTest
    {
        private readonly Customerservices _Customerservices;
       
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Customerservices = new Customerservices(_session);
           
        }

        [Fact]
        public void Test_for_CancelTicket()
        {
            Booking booking = new Booking()
            {
                BookingId = "aa"
            };

            var Result = _Customerservices.CancelTicket(booking.BookingId);

            Assert.True(Result);

        }
        [Fact]
        public void Test_for_EditProfile()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "aaa",
                Password = "aaaa",
                SSNNumber = "aaa",
                SSNType = "sss",
                Address = "aaaa",
                DOB = DateTime.Now,
                Email = "aa@gmail.com",
                Gender = "f",
            };

            var result = _Customerservices.EditProfile(customer);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_RegisterCustomer()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "aaa",
                Password = "aaaa",
                SSNNumber = "aaa",
                SSNType = "sss",
                Address = "aaaa",
                DOB = DateTime.Now,
                Email = "aa@gmail.com",
                Gender = "f",
                PhoneNumber = "11111111"
            };

            var result = _Customerservices.RegisterCustomer(customer);
            Assert.True(result);

        }

        [Fact]
        public void Test_for_Searchflight()
        {
            FlightDetails flightDetails = new FlightDetails()
            {
                To_Location = "aa",
                SeatToBook = 1,
                DepartureDate = DateTime.Now,
                From_Location="dd",
                StartTime=DateTime.Now
                
            };

            var result = _Customerservices.Searchflight(flightDetails.From_Location, flightDetails.To_Location,flightDetails.StartTime, flightDetails.DepartureDate,flightDetails.SeatToBook);
            var GetFlightDeatils = _Customerservices.GetFlightDetails(flightDetails.From_Location, flightDetails.To_Location, flightDetails.StartTime, flightDetails.DepartureDate, flightDetails.SeatToBook);

            Assert.Equal(GetFlightDeatils, result);
        }

        [Fact]
        public void Test_for_TicketBooking()
        {
            Booking booking = new Booking()
            {
                BookingId = "1",
                
                GoingTo = "dd",
                LeavingFrom = "dd",
                NumberOfPassengers = 1,
                Password = "1111",
               
            };

            var Result = _Customerservices.TicketBooking(booking);
            Assert.True(Result);
        }
    }
}
