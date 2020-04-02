﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicelBooking.Test.Exceptions
{
   public class EmailAlreadyExistException:Exception
    {
        public string Messages = "Email Already Exist";

        public EmailAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
