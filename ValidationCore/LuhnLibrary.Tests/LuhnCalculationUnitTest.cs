using System;
using LuhnCheck;
using LuhnLibrary;
using Xunit;

namespace LuhnValidationUnitTests
{
    public class LuhnCalculationUnitTest
    {
        private readonly LuhnValidator luhnCandidate = new LuhnValidator();

        [Theory]
        [InlineData("12", "125")]
        [InlineData("19", "190")]
        [InlineData("123456789", "1234567897")]
        [InlineData("8900123490123456789", "89001234901234567898")] // ICCID test case
        public void CheckLuhnOutput(string input, string expectedValue) {
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData("12", 5)]
        [InlineData("123456789", 7)]
        [InlineData("8900123490123456789", 8)] // ICCID test case
        public void CheckLuhnReturn(string input, int expectedValue) {
            int actualValue = luhnCandidate.ReturnLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData("125", true)]
        [InlineData("1234567897", true)]
        [InlineData("1234567899", false)]
        [InlineData("89001234901234567898", true)] // ICCID test case
        public void CheckLuhnValidation(string input, bool expectedValue) {
            bool actualValue = luhnCandidate.CheckLuhnSuffixReturnBool(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
