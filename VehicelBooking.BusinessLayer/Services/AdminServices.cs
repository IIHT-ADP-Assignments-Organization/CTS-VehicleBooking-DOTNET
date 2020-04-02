using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.BusinessLayer.Interfaces;
using VehicelBooking.DataLayer.NHibernateConfiguration;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {

        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            return true;
        }

        public bool CreateAccount(Admin admin)
        {
            return true;
        }

        public Branch ViewStock(int BranchId)
        {
            Branch branch = new Branch();
            return branch;
        }
    }
}
