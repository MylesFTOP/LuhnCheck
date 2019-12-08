using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class Input
    {
        protected string inputString = "";
        protected decimal parsedInput = 0;
        protected bool parseSucceeded = false;

        public static List<Input> inputs = new List<Input>();

        public string InputString
        {
            get { return inputString; }
            set { inputString = value; }
        }

        public bool ValidInput
        {
            get { return parseSucceeded; }
        }

        public static void EchoInput()
        {
            foreach (var input in inputs)
            {
                Console.WriteLine($"You have entered the following number: {input.InputString}");
            }
        }

        public void ParseInputString()
        {
            string msg = "";

            try
            {
                if (decimal.TryParse(inputString, out parsedInput) == false)
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

        protected bool validLuhn = false;

        public bool ValidLuhn
        {
            get { return validLuhn; }
        }

        public void ValidateInputString()
        {
            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if (ValidInput == true)
            {
                // Code to follow, first testing that invalid format of input throws exception
                validLuhn = true;
            }
        }
    }
}
