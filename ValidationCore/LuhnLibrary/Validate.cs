using System;

namespace LuhnLibrary
{
    public class Validate
    {
        bool validLuhn = false;

        public bool ValidLuhn
        {
            get { return validLuhn; }
        }
        /*
        private void ValidateInputString()
        {
            // Default is modulo 10 version of Luhn for now - possibly extend to modulo n in future
            if ( == true)
            {
                // Code to follow, first testing that invalid format of input throws exception
                validLuhn = true;
            }
        }
        */
    }
}
