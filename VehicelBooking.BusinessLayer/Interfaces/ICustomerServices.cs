using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Interfaces
{
   public interface ICustomerServices
    {
        bool CreateAccount(Customer customer);
        Vehicle SearchVehicle(string VehicleName);
        bool BookVehicle(int VehicleId);
        Vehicle GetVehicle(string VehicleName);
    }
}
