using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.BusinessLayer.Services;
using VehicelBooking.DataLayer.NHibernateConfiguration;
using VehicelBooking.Entities;
using Xunit;

namespace VehicelBooking.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly CustomerServices _CustomerServices;
        private readonly BranchServices _BranchServices;
        private readonly AdminServices _AdminServices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _CustomerServices = new CustomerServices(_session);
            _BranchServices = new BranchServices(_session);
            _AdminServices = new AdminServices(_session);
        }

        [Fact]
        public void Test_for_BookVehicle()
        {
            Vehicle vehicle = new Vehicle()
            {
                VehicleId = 1
            };

            var Result = _CustomerServices.BookVehicle(vehicle.VehicleId);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_CreateAccount()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                UserName = "aaa",
                Email = "dd@gmail.com",
                Password = "aaa",
                PhoneNumber = "1234567",
            };

            var Result = _CustomerServices.CreateAccount(customer);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_SearchVehicle()
        {
            Vehicle vehicle = new Vehicle()
            {
                Vehiclename = "aaa"
            };

            var Result = _CustomerServices.SearchVehicle(vehicle.Vehiclename);
            var getVehicle = _CustomerServices.GetVehicle(vehicle.Vehiclename);

            Assert.Equal(getVehicle, Result);
        }

        [Fact]
        public void Test_for_ApproveVehicle()
        {
            Vehicle vehicle = new Vehicle()
            {
                VehicleId = 1,
            };

            Customer customer = new Customer()
            {
                CustomerId = 1,
            };

            var result = _BranchServices.ApproveVehicle(vehicle.VehicleId, customer.CustomerId);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_CreateAccountforBranch()
        {
            Branch branch = new Branch()
            {
                BranchId = "1",
                BranchName = "aa",
                BranchLocation = "aaa",
                Email = "s@gmail.com",
                Password = "aaa",
                PhoneNumber = "1111111111",
                TotalVehicle = 12,
                UserName = "aaaa"
            };

            var result = _BranchServices.CreateAccount(branch);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_AddVehicle()
        {
            Vehicle vehicle = new Vehicle()
            {
                VehicleId = 1,
                Vehiclename = "ss",
                VehiclePrice = 123,
                BranchId = "1",
            };

            var result = _AdminServices.AddVehicle(vehicle);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_CreateAccountForAdmin()
        {
            Admin admin = new Admin()
            {
                AdminId = 1,
                Email = "aa@gmail.com",
                Password = "aa",
                PhoneNumber = "12345678",
                UserName = "aaa"
            };

            var result = _AdminServices.CreateAccount(admin);
            Assert.True(result);
            
        }

      
    }
}
