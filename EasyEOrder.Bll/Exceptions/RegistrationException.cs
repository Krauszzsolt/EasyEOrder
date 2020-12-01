using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException(string message) : base(message)
        {
        }
    }
}
