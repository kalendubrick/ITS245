using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    abstract class Telephone
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
                if (TelephoneNumber.isValid(value))
                    phoneNumber = value;
                else
                    throw new InvalidPhoneNumberException("There is an exception: '" + value + "' is not a valid phone number!");
            }
        }

        public void dial(string number)
        {
            string convertedNumber;

            if (isConnected)
            {
                Console.WriteLine("You are still connected.  Please hand up first.");
            }
            else if (TelephoneNumber.isValid(number))
            {
                convertedNumber = TelephoneNumber.convert(number);
                Console.WriteLine("Connecting to {0} from {1}...", convertedNumber, phoneNumber);
                Console.WriteLine("Connected.");
                // set the phone to connected and store the number
                isConnected = true;
                lastNumberDialed = convertedNumber;
            }
            else
                throw new InvalidPhoneNumberException("There is an exception: '" + number + "' is not a valid phone number!");
        }

        public abstract void display();
        
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
