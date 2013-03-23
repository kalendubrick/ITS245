using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class CallerId
    {
        private string callerName;
        private string callerPhoneNumber;

        public CallerId() { }

        public CallerId(string callerName, string callerPhoneNumber)
        {
            this.callerName = callerName;
            this.callerPhoneNumber = callerPhoneNumber;
        }

        public string CallerName
        {
            set
            {
                callerName = value;
            }
        }

        public string CallerPhoneNumber
        {
            set
            {
                callerPhoneNumber = value;
            }
        }

        new public string ToString()
        {
            return callerName + ": " + callerPhoneNumber;
        }
    }
}
