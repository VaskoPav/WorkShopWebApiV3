﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieAPI.Shared.Exceptions
{
    public class UserException:Exception
    {
        public UserException(string message) : base(message)
        {

        }
    }
}
