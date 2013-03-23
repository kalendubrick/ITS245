using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab7
{
    class LandLinePhone : Telephone
    {
        private bool hasCord;

        public LandLinePhone() : base() { }

        public LandLinePhone(string maker, string phoneModel, string phoneNumber, bool hasCord)
            : base(maker, phoneModel, phoneNumber)
        {
            this.hasCord = hasCord;
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

        public override void display()
        {
            base.display();
            if (hasCord == true)
                Console.WriteLine("Cordless: No");
            else
                Console.WriteLine("Cordless: Yes");
        }

        public void readDataFrom(BinaryReader r)
        {
            this.Manufacturer = r.ReadString();
            this.Model = r.ReadString();
            this.PhoneNumber = r.ReadString();
            this.HasCord = r.ReadBoolean();
        }

        public void saveDataTo(BinaryWriter w)
        {
            this.PhoneNumber = TelephoneNumber.convert(this.PhoneNumber);

            w.Write(this.Manufacturer);
            w.Write(this.Model);
            w.Write(this.PhoneNumber);
            w.Write(this.HasCord);
        }
    }
}
