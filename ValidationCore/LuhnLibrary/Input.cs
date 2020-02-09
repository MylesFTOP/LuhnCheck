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

        public static void EchoInput()
        {
            foreach (var input in inputs)
            {
                Console.WriteLine($"You have entered the following number: {input.InputString}");
            }
        }

        public void ParseInputString()
        {
            try
            {
                // Uses decimal as ICCIDs can be up to 70 bits long
                if (decimal.TryParse(inputString, out parsedInput) == false)
                {
                    string msg = "Input must be a number.";
                    throw new FormatException(msg);
                }
                if (inputString.IndexOf('.') >= 0)
                {
                    string msg = "Input must not be a decimal.";
                    throw new FormatException(msg);
                }
                parseSucceeded = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}