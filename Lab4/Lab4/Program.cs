using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string callNumber;
                       
            // create the object
            LandLinePhone myPhone = new LandLinePhone();

            // get information for myPhone
            Console.WriteLine("=== myPhone ===");
            Console.Write("Enter the Phone Manufacturer: ");
            myPhone.Manufacturer = Console.ReadLine();
            Console.Write("Enter the Phone Model: ");
            myPhone.Model = Console.ReadLine();
            Console.Write("Is is cordless? [Y or N]: ");
            switch (Console.ReadLine())
            {
                case "Y":
                    myPhone.HasCord = false;
                    break;
                case "y":
                    myPhone.HasCord = false;
                    break;
                case "N":
                    myPhone.HasCord = true;
                    break;
                case "n":
                    myPhone.HasCord = true;
                    break;
            }
            Console.Write("Enter the Phone Number: ");
            myPhone.PhoneNumber = Console.ReadLine();

            // test phone object
            Console.Write("Enter the Number you wish to call: ");
            callNumber = Console.ReadLine();

            Console.WriteLine();

            myPhone.display();
            myPhone.dial(callNumber);
            myPhone.redial();
            myPhone.handUp();

            Console.WriteLine();
        }
    }
}
