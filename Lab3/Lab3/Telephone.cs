using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Telephone
    {
        private string manufacturer;
        private string model;
        private bool hasCord;
        private bool isConnected;
        private string phoneNumber;
        private string lastNumberDialed;

        public Telephone()
        {
            isConnected = false;
        }

        public Telephone(string maker, string phoneModel, bool cordless, string number)
        {
            manufacturer = maker;
            model = phoneModel;
            hasCord = !(cordless);
            phoneNumber = number;
            isConnected = false;
        }

        public bool HasCord
        {
            get
            {
                return hasCord;
            }
            set
            {
                hasCord = value;
            }
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
            Console.WriteLine("Connecting to {0} from {1}...", number, phoneNumber);
            Console.WriteLine("Connected.");
            // set the phone to connected and store the number
            isConnected = true;
            lastNumberDialed = number;
        }

        public void display()
        {
            Console.WriteLine("Manufacturer: {0}", manufacturer);
            Console.WriteLine("Model: {0}", model);
            if (hasCord == true)
                Console.WriteLine("Cordless: No");
            else
                Console.WriteLine("Cordless: Yes");
            Console.WriteLine("Phone Number: {0}", phoneNumber);
        }

        public void handUp()
        {
            Console.WriteLine("Disconnected.");
            isConnected = false;
        }

        public void redial()
        {
            Console.WriteLine("Re-connecting to {0} from {1}...", lastNumberDialed, phoneNumber);
            Console.WriteLine("Connected.");
            // set the phone to connected
            isConnected = true;
        }
    }
}
