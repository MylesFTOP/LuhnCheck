using System;

namespace LuhnLibrary
{
    public class LuhnValidator

    {
        public string AddLuhnSuffix(string input)
            => input + CalculateLuhnDigit(input);

        public bool CheckLuhnSuffixReturnBool(string input) {
            var inputWithoutSuffix = input.Substring(0, input.Length - 1);
            var inputSuffix = input.Substring(input.Length - 1, 1);
            return (CalculateLuhnDigit(inputWithoutSuffix) == Int32.Parse(inputSuffix));
        }

        public string CheckLuhnSuffixReturnString(string input)
            => CheckLuhnSuffixReturnBool(input) ? "valid" : "not valid";

        public int CalculateLuhnSuffix(string input)
            => CalculateLuhnDigit(input);

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
            var reducedLuhnDigit = 0;

            while (luhnDigit != 0 ) { 
                reducedLuhnDigit += luhnDigit % 10;
                luhnDigit /= 10;
            }
            return reducedLuhnDigit;
        }
    }
}
