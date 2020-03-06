using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LuhnCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with calculating Luhn check digit for a string that doesn't have one
            // Luhn algorithm: starting from the right, take every other digit and double it, then add it all together

            string input = "123456789";
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
                { luhnDigit += int.Parse(luhnDigitString.Substring(i,1)); }

            string output = input + luhnDigit;
            Console.WriteLine(output);
        }

        // Next steps: Add unit tests for above operation, then extract it into relevant methods (e.g. CalculateLuhnDigit() ) here
    }
}
