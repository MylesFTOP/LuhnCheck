using System;

namespace LuhnLibrary
{
    public class Validate
    {
        bool parseSuceeded = false;
        bool validLuhn = false;
        
        public bool ValidLuhn
        {
            get { return validLuhn; }
        }

        public void ParseInputString()
        {
            ParseInput ParseInput = new ParseInput();
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
