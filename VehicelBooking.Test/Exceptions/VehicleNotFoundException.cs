using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Test.Exceptions
{
   public class VehicleNotFoundException:Exception
    {
        public string Messages = "Vehicle Not Found";

        public VehicleNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
