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
            LuhnValidator luhnCandidate = new LuhnValidator();
            
            string input = "12";
            string actualValue = "125";
            string expectedValue = LuhnValidator.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnOutput2()
        {
            LuhnValidator luhnCandidate = new LuhnValidator();

            string input = "123456789";
            string actualValue = "1234567897";
            string expectedValue = LuhnValidator.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
