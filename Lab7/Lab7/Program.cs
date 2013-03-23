using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "lab07.dat";

            int numPhones = 0;
            string morePhones = "y", cordless = "";

            // instantiate FileStream and BinaryWriter objects
            if (File.Exists(FILE_NAME))
                Console.WriteLine("File already exists!  Appending.");
            FileStream fs = new FileStream(FILE_NAME, FileMode.Append, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);

            do
            {
                // instantiate phone object
                LandLinePhone writePhone = new LandLinePhone();

                // get user input
                Console.Write("Enter the phone manufacturer: ");
                writePhone.Manufacturer = Console.ReadLine();
                Console.Write("Enter the phone model: ");
                writePhone.Model = Console.ReadLine();
                Console.Write("Is it cordless? [Y or N] ");
                cordless = Console.ReadLine();
                cordless = cordless.ToUpper();
                if (cordless == "Y")
                    writePhone.HasCord = false;
                else if (cordless == "N")
                    writePhone.HasCord = true;
                Console.Write("Enter the phone number: ");
                writePhone.PhoneNumber = Console.ReadLine();

                // save the data to file
                writePhone.saveDataTo(w);

                // see if the user wants to enter more phones
                Console.Write("Would you like to enter another telephone? [y or n] ");
                morePhones = Console.ReadLine().ToLower();
                //morePhones = morePhones.ToLower();

                numPhones++;
                Console.WriteLine();
            }
            while (morePhones == "y");

            // close FileStream and BinaryWriter objects
            w.Close();
            fs.Close();

            // instantiate FileStream and BinaryReader objects
            fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            // display header
            Console.WriteLine("==== output telephones ====");

            for (int i = 0; i < numPhones; i++)
            {
                // instantiate phone object
                LandLinePhone readPhone = new LandLinePhone();

                // populate phone data from file
                readPhone.readDataFrom(r);

                // display phone info
                Console.WriteLine("--- phone #{0} ---", i + 1);
                readPhone.display();
                Console.WriteLine();
            }

            // close FileStream and BinaryReader objects
            r.Close();
            fs.Close();

            // display trailer
            Console.WriteLine("A total of {0} telephones", numPhones);
        }
    }
}
