using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cordless;

            try
            {
                // create the objects
                LandLinePhone yourHomePhone = new LandLinePhone();

                // get info for yourHomePhone
                Console.Write("Enter the Phone Manufacturer: ");
                yourHomePhone.Manufacturer = Console.ReadLine();
                Console.Write("Enter the Phone Model: ");
                yourHomePhone.Model = Console.ReadLine();
                Console.Write("Is it cordless? [Y or N]: ");
                cordless = Console.ReadLine();
                if (cordless == "Y" || cordless == "y")
                    yourHomePhone.HasCord = false;
                else if (cordless == "N" || cordless == "n")
                    yourHomePhone.HasCord = true;
                Console.Write("Enter the Phone #: ");
                yourHomePhone.PhoneNumber = Console.ReadLine();

                // test the yourHomePhone object
                Console.WriteLine();
                yourHomePhone.display();
                yourHomePhone.dial(inputPhoneNumberToDial());
                Console.WriteLine();
                yourHomePhone.handUp();
                Console.WriteLine();
            }
            catch (InvalidPhoneNumberException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please try again.");
            }
        }

        private static string inputPhoneNumberToDial()
        {
            Console.Write("Enter the phone number to dial: ");
            return Console.ReadLine();
        }
    }
}
