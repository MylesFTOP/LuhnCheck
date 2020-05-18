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

        public int ReturnLuhnSuffix(string input) {
            int output = Int32.Parse(CalculateLuhnDigit(input));
            return output;
        }

        private string CalculateLuhnDigit(string input) {
            int luhnDigit = 0;

            for (int i = 0; i < input.Length; i++) {
                int currentDigit = int.Parse(input.Substring((input.Length - i - 1), 1));
                luhnDigit += (i % 2 == 0) ? ReduceToDigitSum(2 * currentDigit) : currentDigit;
            }
            
            luhnDigit = (10 - (luhnDigit % 10)) % 10;
            string luhnDigitString = luhnDigit.ToString();
            return luhnDigitString;
        }

        private int ReduceToDigitSum(int luhnDigit) {
            int reducedLuhnDigit = 0;

            while (luhnDigit != 0 ) { 
                reducedLuhnDigit += luhnDigit % 10;
                luhnDigit /= 10;
            }
            return reducedLuhnDigit;
        }
    }
}
