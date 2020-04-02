using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Entities
{
   public class Vehicle
    {
        public virtual int VehicleId { get; set; }
        public virtual string Vehiclename { get; set; }
        public virtual long VehiclePrice { get; set; }
        public virtual string BranchId { get; set; }
    }
}
