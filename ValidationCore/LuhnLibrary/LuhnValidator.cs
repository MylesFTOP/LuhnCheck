using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class LuhnValidator
    {
        public static string CalculateLuhnDigit(string input)
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

            string output = input + luhnDigit;
            Console.WriteLine(output);
            return output;
        }
    }
}
