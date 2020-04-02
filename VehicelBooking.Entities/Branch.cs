using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Entities
{
   public class Branch
    {
        public virtual string BranchId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual string BranchName { get; set; }
        public virtual string BranchLocation { get; set; }
        public virtual long TotalVehicle { get; set; }

    }
}
