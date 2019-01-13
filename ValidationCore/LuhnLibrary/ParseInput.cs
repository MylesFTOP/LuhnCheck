using System;

namespace LuhnLibrary
{
    public class ParseInput
    {
        string inputString = "";
        int parsedInput = 0;
        bool parseSucceeded = false;

        public string InputString
        {
            get { return inputString; }
            set { inputString = value; }
        }

        public bool ValidInput
        {
            get { return parseSucceeded; }
        }

        public void ParseInputString()
        {
            string msg = "";

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
    }
}
