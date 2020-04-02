using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.BusinessLayer.Interfaces;
using VehicelBooking.DataLayer.NHibernateConfiguration;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Services
{
    public class BranchServices : IBranchServices
    {
        private readonly IMapperSession _session;

        public BranchServices(IMapperSession session)
        {
            _session = session;
        }

        public bool ApproveVehicle(int vehicleId, int CustomerId)
        {
            return true;
        }

        public bool CreateAccount(Branch branch)
        {
            return true;
        }

        public Vehicle ViewBookingRequest(int BranchId)
        {
            Vehicle vehicle = new Vehicle();
            return vehicle;
        }
    }
}
