using AirTicket.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AirTicket.Test.TestCases
{
    public class BoundaryTest
    {
        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            Customer customer = new Customer()
            {
                Password = "111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForPhoneNumber_Length()
        {

            Customer customer = new Customer()
            {
                PhoneNumber = "9066567887"
            };
            //Arrange
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = customer.PhoneNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_ForCustomerName_Length()
        {

            Customer customer = new Customer()
            {
                Name = "Nithish"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = customer.Name.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForCustomerName_Address()
        {

            Customer customer = new Customer()
            {
                Address = "gtnjuikuy"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 100;

            //Action
            var actualLength = customer.Address.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_Location()
        {

            FlightDetails flightDetails = new FlightDetails()
            {
                From_Location = "Bangalore",
                To_Location = "Bangalore"
            };

            //Action
            var leavinglocation = flightDetails.From_Location;
            var goinglocation = flightDetails.From_Location;

            //Assert
            Assert.NotEqual(leavinglocation, goinglocation);
        }
        [Fact]
        public void BoundaryTest_ForSeatToBook()
        {


            FlightDetails flightDetails = new FlightDetails()
            {
              SeatToBook=11
            };

            //Arrange
            var MinLength = 1;
            var MaxLength = 20;

            //Action
            var actualLength = flightDetails.SeatToBook.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


    }

}
