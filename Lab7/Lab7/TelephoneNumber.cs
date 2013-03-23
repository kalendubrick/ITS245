using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class TelephoneNumber
    {
        public static bool isValid(string phoneNumber)
        {
            String upperString = phoneNumber.ToUpper();
            bool validNumber = true;

            for (int i = 0; i < upperString.Length; i++)
            {
                if (!(Char.IsLetterOrDigit(upperString[i])) && upperString[i] != '-')
                {
                    validNumber = false;
                }
            }

            return validNumber;
        }

        public static string convert(string phoneNumber)
        {
            String upperString = phoneNumber.ToUpper();
            for (int i = 0; i < upperString.Length; i++)
            {
                if (Char.IsLetter(upperString[i]))
                {
                    upperString = upperString.Replace(upperString[i], getNumericDigit(upperString[i]));
                }
            }

            return upperString;
        }

        private static char getNumericDigit(char digit)
        {
            char tempDigit = digit;

            switch (digit)
            {
                case 'A':
                case 'B':
                case 'C':
                    tempDigit = '2';
                    break;
                case 'D':
                case 'E':
                case 'F':
                    tempDigit = '3';
                    break;
                case 'G':
                case 'H':
                case 'I':
                    tempDigit = '4';
                    break;
                case 'J':
                case 'K':
                case 'L':
                    tempDigit = '5';
                    break;
                case 'M':
                case 'N':
                case 'O':
                    tempDigit = '6';
                    break;
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    tempDigit = '7';
                    break;
                case 'T':
                case 'U':
                case 'V':
                    tempDigit = '8';
                    break;
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    tempDigit = '9';
                    break;
            }

            return tempDigit;
        }
    }
}
