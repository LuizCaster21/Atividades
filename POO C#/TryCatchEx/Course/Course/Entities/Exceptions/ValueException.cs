﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exceptions
{
    internal class ValueException : ApplicationException
    {
        public ValueException (string message) : base (message)
        {

        }
    }
}
