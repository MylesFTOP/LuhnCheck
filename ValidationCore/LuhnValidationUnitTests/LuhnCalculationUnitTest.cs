using System;
using LuhnCheck;
using LuhnLibrary;
using Xunit;

namespace LuhnValidationUnitTests
{
    public class LuhnCalculationUnitTest
    {
        private LuhnValidator luhnCandidate = new LuhnValidator();

        [Fact]
        public void checkLuhnOutput()
        {
            string input = "12";
            string actualValue = "125";
            string expectedValue = luhnCandidate.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnOutput2()
        {
            string input = "123456789";
            string actualValue = "1234567897";
            string expectedValue = luhnCandidate.CalculateLuhnDigit(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
