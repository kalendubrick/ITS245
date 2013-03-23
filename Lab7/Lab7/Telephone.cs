using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Telephone
    {
        private string manufacturer;
        private string model;
        private bool isConnected;
        private string phoneNumber;
        private string lastNumberDialed;

        public Telephone()
        {
            isConnected = false;
        }

        public Telephone(string maker, string phoneModel, string number)
        {
            manufacturer = maker;
            model = phoneModel;
            phoneNumber = number;
            isConnected = false;
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public void dial(string number)
        {
            if (isConnected)
            {
                Console.WriteLine("You are still connected.  Please hand up first.");
            }
            else
            {
                Console.WriteLine("Connecting to {0} from {1}...", number, phoneNumber);
                Console.WriteLine("Connected.");
                // set the phone to connected and store the number
                isConnected = true;
                lastNumberDialed = number;
            }
        }

        public virtual void display()
        {
            Console.WriteLine("Manufacturer: {0}", manufacturer);
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Phone Number: {0}", phoneNumber);
        }

        public void handUp()
        {
            Console.WriteLine("Disconnected.");
            isConnected = false;
        }

        public void redial()
        {
            if (isConnected)
            {
                Console.WriteLine("You are still connected.  Please hand up first.");
            }
            else
            {
                Console.WriteLine("Re-connecting to {0} from {1}...", lastNumberDialed, phoneNumber);
                Console.WriteLine("Connected.");
                // set the phone to connected
                isConnected = true;
            }
        }
    }
}
