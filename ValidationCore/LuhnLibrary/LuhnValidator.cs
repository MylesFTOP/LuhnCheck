using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class LuhnValidator
    {
        public string AddLuhnSuffix(string input) {
            string output = input + CalculateLuhnDigit(input);
            return output;
        }

        public bool CheckLuhnSuffix(string input) {
            bool output = false;
            string suffix = CalculateLuhnDigit(input.Substring(0 , input.Length - 1));

            output = (suffix == input.Substring(input.Length - 1 , 1)) ? true : false ;
            return output;
        }

        public string CalculateLuhnDigit(string input) {
            int luhnDigit = 0;
            int singleOperands = 0;
            int doubleOperands = 0;

            for (int i = 0; i < input.Length; i++) {
                int currentDigit = int.Parse(input.Substring((input.Length - i - 1), 1));

                // luhnDigit += (i % 2 == 0) ? 2 * currentDigit : currentDigit;

                if (i % 2 == 0)
                { doubleOperands += 2 * currentDigit; }
                else
                { singleOperands += currentDigit; }
            }
            luhnDigit = singleOperands + doubleOperands;

            string luhnDigitString = ReduceLuhnDigitString(luhnDigit);
            return luhnDigitString;
        }

        public string ReduceLuhnDigitString(int luhnDigit) {
            int reducedLuhnDigit = 0;

            while (luhnDigit != 0 || reducedLuhnDigit > 9) { 
                reducedLuhnDigit += luhnDigit % 10;
                luhnDigit /= 10;
                if (luhnDigit == 0 && reducedLuhnDigit > 9) {
                    luhnDigit = reducedLuhnDigit;
                    reducedLuhnDigit = 0;
                }
            }

            string luhnDigitString = reducedLuhnDigit.ToString();
            return luhnDigitString;
        }
    }
}
