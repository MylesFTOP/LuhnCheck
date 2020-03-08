using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class LuhnValidator
    {
        public string AddLuhnSuffix(string input)
        {
            string output = input + CalculateLuhnDigit(input);
            return output;
        }

        public bool CheckLuhnSuffix(string input)
        {
            bool output = false;
            string suffix = CalculateLuhnDigit(input.Substring(0 , input.Length - 1));

            if (suffix == input.Substring(input.Length - 1 , 1))
                output = true;
            else
                output = false;

            return output;
        }

        public string CalculateLuhnDigit(string input)
        {
            int luhnDigit = 0;
            int singleOperands = 0;
            int doubleOperands = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentDigit = int.Parse(input.Substring(input.Length - i - 1, 1));

                if (i % 2 == 0)
                { doubleOperands += currentDigit; }
                else
                { singleOperands += currentDigit; }
            }

            luhnDigit = singleOperands + (2 * doubleOperands);
            string luhnDigitString = luhnDigit.ToString();
            luhnDigit = 0;

            for (int i = 0; i < luhnDigitString.Length; i++)
            { luhnDigit += int.Parse(luhnDigitString.Substring(i, 1)); }
            luhnDigitString = luhnDigit.ToString();

            return luhnDigitString;
        }

        
    }
}
