using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Entities
{
   public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime DOB { get; set; }

        public virtual string Email { get; set; }
        
    }
}
