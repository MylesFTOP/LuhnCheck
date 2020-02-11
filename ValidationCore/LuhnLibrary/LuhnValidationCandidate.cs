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
        protected int luhnCheckDigit;
        
        public bool alreadyHasCheckDigit = false;
        public string inputString = "";

        public bool AlreadyHasCheckDigit 
        {
            get { return alreadyHasCheckDigit; }
            set { alreadyHasCheckDigit = value; }  
        }
        
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

        public LuhnValidationCandidate (bool alreadyHasCheckdigit)
        {
            this.AlreadyHasCheckDigit = alreadyHasCheckDigit;
        }

        public string GenerateLuhn()
        {
            if (alreadyHasCheckDigit == true)
                return inputString;

            if (alreadyHasCheckDigit == false)
                return inputString;

            else return "Error: Unknown whether input has a check digit already";
        }

        public void ValidateInputString()
        {
            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if (ValidInput == true && alreadyHasCheckDigit == true)
            {
                GenerateLuhn();
                validLuhn = true;
            }

            else if (ValidInput == true && alreadyHasCheckDigit == false)
            {
                Console.WriteLine("Cannot be validated - needs to already have a check digit");
            }

            else validLuhn = false;
        }
    }
}
