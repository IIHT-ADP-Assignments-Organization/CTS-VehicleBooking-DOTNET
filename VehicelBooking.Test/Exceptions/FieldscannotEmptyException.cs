using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Test.Exceptions
{
   public class FieldscannotEmptyException:Exception
    {
        public string Messages = "Fields can not be blank";

        public FieldscannotEmptyException(string message)
        {
            Messages = message;
        }
    }
}
