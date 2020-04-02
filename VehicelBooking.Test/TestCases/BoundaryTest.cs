using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.Entities;
using Xunit;

namespace VehicelBooking.Test.TestCases
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
            var MaxLength = 20;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForDateofBirth()
        {

            Customer customer = new Customer()
            {
                DOB = DateTime.Now
            };


            //Action
            var DateOfbirth = customer.DOB;

            //Assert
            Assert.NotEqual(DateOfbirth, DateOfbirth);
        }
        public void BoundaryTest_ForAdminPassword_Length()
        {
            Admin Admin = new Admin()
            {
                Password = "111"
            };
            var MinLength = 8;
            var MaxLength = 20;

            //Action
            var actualLength = Admin.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForAdminDateofBirth()
        {

            Customer customer = new Customer()
            {
                DOB = DateTime.Now
            };


            //Action
            var DateOfbirth = customer.DOB;

            //Assert
            Assert.NotEqual(DateOfbirth, DateOfbirth);
        }

        [Fact]
        public void BoundaryTest_ForPhoneNumber_Pattern()
        {

            Customer customer = new Customer()
            {
                PhoneNumber = "9066567887"
            };


            //Action
            var Phone = customer.PhoneNumber;

            //Assert
            Assert.Matches(Phone, "011 – 2239920");
        }

    }

}

