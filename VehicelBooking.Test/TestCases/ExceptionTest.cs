using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.BusinessLayer.Services;
using VehicelBooking.DataLayer.NHibernateConfiguration;
using VehicelBooking.Entities;
using VehicelBooking.Test.Exceptions;
using Xunit;

namespace VehicelBooking.Test.TestCases
{
    public class ExceptionTest
    {
        private readonly CustomerServices _Customerservices;
        private readonly AdminServices _AdminServices;
        private readonly BranchServices _BranchServices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AdminServices = new AdminServices(_session);
            _Customerservices = new CustomerServices(_session);
            _BranchServices = new BranchServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblank()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                UserName = "abc",
                PhoneNumber = "8987656778",
                Password = "123",
                Email = "example@gmail.com",
                DOB = DateTime.Now

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _Customerservices.CreateAccount(customer));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_BranchCannotblank()
        {
            Branch Branch = new Branch()
            {
                BranchId =" 1",
                UserName = "abc",
                PhoneNumber = "8987656778",
                Password = "123",
                Email = "example@gmail.com",
                BranchName = "abc",
                BranchLocation = "gadag",
                TotalVehicle = 50

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _BranchServices.CreateAccount(Branch));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_AdminCannotblank()
        {
            Admin Admin = new Admin()
            {
                AdminId = 1,
                UserName = "abc",
                PhoneNumber = "8987656778",
                Password = "123",
                Email = "example@gmail.com"


            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdminServices.CreateAccount(Admin));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_VehicleNotFound()
        {
            Vehicle vehicle = new Vehicle()
            {
                Vehiclename = "KTM"

            };
            //Assert
            var ex = Assert.Throws<VehicleNotFoundException>(() => _Customerservices.SearchVehicle(vehicle.Vehiclename));
            Assert.Equal("Vehicle Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_EmailAlreadyExist()
        {
            Customer customer = new Customer()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _Customerservices.CreateAccount(customer));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }




    }
}


