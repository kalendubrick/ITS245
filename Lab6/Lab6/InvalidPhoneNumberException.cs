using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class InvalidPhoneNumberException : ApplicationException
    {
        public InvalidPhoneNumberException() { }
        public InvalidPhoneNumberException(string message) : base(message) { }
        public InvalidPhoneNumberException(string message, Exception innerEx)
            : base(message, innerEx) { }
    }
}
