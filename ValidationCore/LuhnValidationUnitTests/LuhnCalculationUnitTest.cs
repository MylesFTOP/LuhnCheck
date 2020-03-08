using System;
using LuhnCheck;
using LuhnLibrary;
using Xunit;

namespace LuhnValidationUnitTests
{
    public class LuhnCalculationUnitTest
    {
        [Fact]
        public void checkLuhnOutput()
        {
            string input = "12";
            LuhnValidator luhnCandidate = new LuhnValidator();
            
            string expectedValue = LuhnValidator.CalculateLuhnDigit(input);
            string actualValue = Program.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnOutput2()
        {
            string input = "123456789";
            LuhnValidator luhnCandidate = new LuhnValidator();

            string expectedValue = LuhnValidator.CalculateLuhnDigit(input);
            string actualValue = Program.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
