﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class LuhnValidation
    {
        protected bool validLuhn = false;
        protected bool parseSucceeded = false;

        public bool ValidInput
        {
            get { return parseSucceeded; }
        }

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
