using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
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

        public string dial(string number)
        {
            string returnString;

            if (isConnected)
            {
                returnString = "You are still connected.  Please hang up first.";
            }
            else
            {
                returnString = "Connecting to " + number.ToString() + " from " +
                                phoneNumber.ToString() + Environment.NewLine + "Connected.";
              
                // set the phone to connected and store the number
                isConnected = true;
                lastNumberDialed = number;
            }

            return returnString;
        }

        public override string ToString()
        {
            return "Manufacturer: " + manufacturer + "\r\n" +
                    "Model: " + model + "\r\n" +
                    "Phone Number: " + phoneNumber;
        }

        public string hangUp()
        {
            isConnected = false;
            return "Disconnected.";
        }

        public string redial()
        {
            string returnString;

            if (isConnected)
            {
                returnString = "You are still connected.  Please hang up first.";
            }
            else
            {
                returnString = "Re-connecting to " + lastNumberDialed.ToString() + " from " +
                                phoneNumber.ToString() + Environment.NewLine + "Connected";
                // set the phone to connected
                isConnected = true;
            }

            return returnString;
        }
    }
}
