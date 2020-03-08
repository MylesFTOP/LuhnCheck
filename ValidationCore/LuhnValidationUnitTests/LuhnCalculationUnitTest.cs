﻿using System;
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
            string expectedValue = "125";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnOutput2()
        {
            string input = "123456789";
            string expectedValue = "1234567897";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnValidation()
        {
            string input = "125";
            bool expectedValue = true;
            bool actualValue = luhnCandidate.CheckLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void checkLuhnValidation2()
        {
            string input = "1234567897";
            bool expectedValue = true;
            bool actualValue = luhnCandidate.CheckLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
