using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string maker = "AT&T";
            string phoneModel = "T-3432";
            bool cordless = true;
            string number = "219-989-1234";
            string callNumber;

            // create objects
            Telephone myPhone = new Telephone();
            Telephone yourPhone = new Telephone(maker, phoneModel, cordless, number);

            // get information for myPhone
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

            // test phone objects
            Console.Write("Enter the Number you wish to call: ");
            callNumber = Console.ReadLine();

            Console.WriteLine();

            // myPhone
            Console.WriteLine("=== myPhone ==");
            myPhone.display();
            myPhone.dial(callNumber);
            myPhone.handUp();
            myPhone.redial();
            myPhone.handUp();

            Console.WriteLine();

            // yourPhone
            Console.WriteLine("=== yourPhone ==");
            yourPhone.display();
            yourPhone.dial(callNumber);
            yourPhone.handUp();
            yourPhone.redial();
            yourPhone.handUp();

        }
    }
}
