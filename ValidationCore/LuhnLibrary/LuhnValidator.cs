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

        public bool CheckLuhnSuffixReturnBool(string input) {
            bool output = false;
            var inputWithoutSuffix = input.Substring(0, input.Length - 1);
            var inputSuffix = Int32.Parse(input.Substring(input.Length - 1, 1));
            output = (inputSuffix == CalculateLuhnDigit(inputWithoutSuffix)) ? true : false ;
            return output;
        }

        public string CheckLuhnSuffixReturnString(string input) {
            string result = CheckLuhnSuffixReturnBool(input) ? "valid" : "not valid";
            return result;
        }

        public int ReturnLuhnSuffix(string input) {
            int output = CalculateLuhnDigit(input);
            return output;
        }

        private int CalculateLuhnDigit(string input) {
            int luhnDigit = 0;

            for (int i = 0; i < input.Length; i++) {
                int currentDigit = int.Parse(input.Substring((input.Length - i - 1), 1));
                luhnDigit += (i % 2 == 0) ? ReduceToDigitSum(2 * currentDigit) : currentDigit;
            }
            
            luhnDigit = (10 - (luhnDigit % 10)) % 10;
            return luhnDigit;
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
