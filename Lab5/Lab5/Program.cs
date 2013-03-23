using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string manufacturer = "VTech";
            string model = "V-4321";
            string phoneNumber = "219-999-2345";
            bool hasCord = false;
            string messageText, messagePhoneNumber, callNumber;

            // create the objects
            CallerId callerId = new CallerId();
            CellularPhone myCellPhone = new CellularPhone();
            LandLinePhone yourHomePhone = new LandLinePhone(manufacturer, model, phoneNumber, hasCord);

            // get info for myCellPhone
            Console.WriteLine("=== myCellPhone ===");
            Console.Write("Enter the Cell Phone Manufacturer: ");
            myCellPhone.Manufacturer = Console.ReadLine();
            Console.Write("Enter the Phone Model: ");
            myCellPhone.Model = Console.ReadLine();
            Console.Write("Enter the Phone Technology: ");
            myCellPhone.Technology = Console.ReadLine();
            Console.Write("Does it Have a Built-in Camera? [Y or N]: ");
            switch (Console.ReadLine())
            {
                case "Y":
                    myCellPhone.HasCamera = true;
                    break;
                case "y":
                    myCellPhone.HasCamera = true;
                    break;
                case "N":
                    myCellPhone.HasCamera = false;
                    break;
                case "n":
                    myCellPhone.HasCamera = false;
                    break;
            }
            Console.Write("Enter the Phone # of Your Cell Phone: ");
            myCellPhone.PhoneNumber = Console.ReadLine();
            Console.Write("Enter the Person's Name in the Called Id: ");
            callerId.CallerName = Console.ReadLine();
            Console.Write("Enter the Phone # in the Called Id: ");
            callerId.CallerPhoneNumber = Console.ReadLine();
            myCellPhone.CallerID = callerId;
            callerId.CallerName = "Test";
            callerId.CallerPhoneNumber = "555-555-5555";
            Console.Write("Enter the short text message you wish to send: ");
            messageText = Console.ReadLine();
            Console.Write("Enter the Number you wish to send the text message: ");
            messagePhoneNumber = Console.ReadLine();

            // test the myCellPhone object
            Console.WriteLine();
            myCellPhone.display();
            Console.WriteLine();
            myCellPhone.sendTextMessage(messagePhoneNumber, messageText);
            Console.WriteLine();

            // get info for yourHomePhone
            Console.Write("Enter the Number you wish to call from the landline: ");
            callNumber = Console.ReadLine();

            // test the yourHomePhone object
            Console.WriteLine();
            yourHomePhone.display();
            Console.WriteLine();
            yourHomePhone.dial(callNumber);
            yourHomePhone.redial();
            yourHomePhone.handUp();
            Console.WriteLine();
        }
    }
}
