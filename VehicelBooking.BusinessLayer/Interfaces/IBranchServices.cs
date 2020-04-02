using System;
using System.Collections.Generic;
using System.Text;
using VehicelBooking.Entities;

namespace VehicelBooking.BusinessLayer.Interfaces
{
   public interface IBranchServices
    {
        bool CreateAccount(Branch branch);
        bool ApproveVehicle(int vehicleId, int CustomerId);
        Vehicle ViewBookingRequest(int BranchId);

    }
}
