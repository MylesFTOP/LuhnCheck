using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class Validate
    {
        string inputString = "";
        int parsedInput = 0;
        bool parseSucceeded = false;
        bool validLuhn = false;

        public string InputString
        {
            get { return inputString; }
            set { inputString = value; }
        }

        public bool ValidInput
        {
            get { return parseSucceeded; }
        }

        public bool ValidLuhn
        {
            get { return validLuhn; }
        }

        private void ParseInputString()
        {
            string msg = "";

            // Throw a FormatException if the string does not consist solely of numbers
            try
            {
                if (int.TryParse(inputString, out parsedInput) == false)
                {
                    msg = "\nInput must be a number.";
                    throw new FormatException(msg);
                }
                parseSucceeded = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ValidateInputString()
        {
            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if (parseSucceeded)
            {
                // Code to follow, first testing that invalid format of input throws exception
                validLuhn = true;
            }
        }
    }
}
