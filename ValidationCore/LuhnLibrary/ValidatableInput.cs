using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class ValidatableInput : Input
    {
        private bool parseSuceeded = false;
        private bool validLuhn = false;

        public bool ValidLuhn
        {
            get { return validLuhn; }
        }

        public void ParseInputString()
        {
            ParsableInput ParseInput = new ParsableInput();
            ParseInput.ParseInputString();
            bool parseSuceeded = ParseInput.ValidInput;
        }

        public void ValidateInputString()
        {
            ParseInputString();

            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if (parseSuceeded == true)
            {
                // Code to follow, first testing that invalid format of input throws exception
                validLuhn = true;
            }
        }

    }
}
