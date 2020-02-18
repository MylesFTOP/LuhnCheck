using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class LuhnValidationCandidate
    {
        protected bool validLuhn = false;
        protected bool parseSucceeded = false;
        protected bool alreadyHasCheckDigit = false;
        protected int luhnCheckDigit;
        
        public string inputString = "";
        public decimal parsedInput;
        
        public bool ValidInput
        {
            get { return parseSucceeded; }
            set { parseSucceeded = true; }
        }

        public bool ValidLuhn
        {
            get { return validLuhn; }
            set { validLuhn = true; }
        }

        public int LuhnCheckDigit
        {
            get { return luhnCheckDigit; }
            set { luhnCheckDigit = value; }
        }

        public string GenerateLuhn()
        {
            if (alreadyHasCheckDigit == true) // This will be a case that can be checked
                return inputString;

            if (alreadyHasCheckDigit == false) // This will not
                return inputString;

            else return "Error: Unknown whether input has a check digit already";
        }

        public void ValidateInputString()
        {
            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if (ValidInput == true)
            {
                GenerateLuhn();
                validLuhn = true;
            }

            else validLuhn = false;
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
