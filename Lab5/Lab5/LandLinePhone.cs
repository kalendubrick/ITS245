using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
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
    }
}
