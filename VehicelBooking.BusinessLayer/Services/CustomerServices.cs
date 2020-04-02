using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.BusinessLayer.Interfaces;
using VehicelBooking.DataLayer.NHibernateConfiguration;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Services
{
    public class CustomerServices : ICustomerServices
    {

        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }


        public bool BookVehicle(int VehicleId)
        {
            return true;
        }

        public bool CreateAccount(Customer customer)
        {
            return true;
        }

        public Vehicle GetVehicle(string Vehiclename)
        {
            Vehicle vehicle = new Vehicle();
            return vehicle;
        }

        public Vehicle SearchVehicle(string VehicleName)
        {
            Vehicle vehicle = new Vehicle();
            return vehicle;
        }
    }
}
