using System;
using LuhnCheck;
using Xunit;

namespace LuhnValidationUnitTests
{
    public class LuhnCalculationUnitTest
    {
        [Fact]
        public void checkLuhnOutput()
        {
            string expectedValue = "125";
            string actualValue = LuhnCheck.Program.CalculateLuhnDigit("12");
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnOutput2()
        {
            string expectedValue = "1234567897";
            string actualValue = LuhnCheck.Program.CalculateLuhnDigit("123456789");
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
