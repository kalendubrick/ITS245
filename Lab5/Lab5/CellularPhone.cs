using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class CellularPhone : Telephone
    {
        private CallerId callerId;
        private bool hasCamera;
        private string technology;

        public CellularPhone() { }

        public CellularPhone(string manufacturer, string model, string phoneNumber, string technology, bool hasCamera, CallerId callerId)
            : base(manufacturer, model, phoneNumber)
        {
            this.technology = technology;
            this.hasCamera = hasCamera;
            this.callerId = callerId;
        }

        public CallerId CallerID
        {
            get
            {
                return callerId;
            }
            set
            {
                callerId = value;
            }
        }

        public bool HasCamera
        {
            get
            {
                return hasCamera;
            }
            set
            {
                hasCamera = value;
            }
        }

        public string Technology
        {
            get
            {
                return technology;
            }
            set
            {
                technology = value;
            }
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Technology: {0}", technology);
            if (hasCamera == true)
            {
                Console.WriteLine("Has Camera: Yes");
            }
            else
            {
                Console.WriteLine("Has Camera: No");
            }
            Console.WriteLine("Caller ID: {0}", callerId.ToString());
        }

        public void sendTextMessage(string callNumber, string messageText)
        {
            Console.WriteLine("Sending the following message to {0}...", callNumber);
            Console.WriteLine(messageText);
        }
    }
}
