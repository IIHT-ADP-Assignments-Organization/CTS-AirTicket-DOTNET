using AirTicket.BusinessLayer.Services;
using AirTicket.DataLayer.NHibernateConfiguration;
using AirTicket.Entities;
using AirTicket.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AirTicket.Test.TestCases
{
    public class ExceptionTest
    {
        private readonly Customerservices _Customerservices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {

            _Customerservices = new Customerservices(_session);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblank()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "abc",
                Email = "example@gmail.com",
                Password = "123",
                DOB = DateTime.Now,
                Address = "gadag",
                PhoneNumber = "8987656778",
                Gender = "male",
                SSNType = "abc",
                SSNNumber = "s123"
            };
            //Assert
            var ex = Assert.Throws<CustomercannotEmptyException>(() => _Customerservices.RegisterCustomer(customer));
            Assert.Equal("Customer can not be blank ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_FlightNotFound()
        {
            FlightDetails flightDetails = new FlightDetails()
            {
                To_Location = "aa",
                SeatToBook = 1,
                DepartureDate = DateTime.Now,
                From_Location = "dd",
                StartTime = DateTime.Now

            };
            //Assert
            var ex = Assert.Throws<FlightNotFoundException>(() => _Customerservices.Searchflight(flightDetails.From_Location, flightDetails.To_Location, flightDetails.StartTime, flightDetails.DepartureDate, flightDetails.SeatToBook));
            Assert.Equal("Flight Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_EmailAlreadyExist()
        {
            Customer customer = new Customer()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _Customerservices.RegisterCustomer(customer));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_CustomerNotFound()
        {
            Customer customer = new Customer()
            {
                Id = 5
            };

            //Assert
            var ex = Assert.Throws<CustomerNotFoundException>(() => _Customerservices.GetCustomerById(customer.Id));
            Assert.Equal("Customer Not Found ", ex.Messages);
        }

    }
}


