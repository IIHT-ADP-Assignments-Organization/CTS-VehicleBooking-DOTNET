using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Interfaces
{
  public  interface IAdminServices
    {
        bool CreateAccount(Admin admin);
        Branch ViewStock(int BranchId);
        bool AddVehicle(Vehicle vehicle);
    }
}
