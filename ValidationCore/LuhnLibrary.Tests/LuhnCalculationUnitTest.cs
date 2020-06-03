﻿using System;
using LuhnCheck;
using LuhnLibrary;
using Xunit;

namespace LuhnValidationUnitTests
{
    public class LuhnCalculationUnitTest
    {
        private readonly LuhnValidator luhnCandidate = new LuhnValidator();

        [Fact]
        public void CheckLuhnOutput() {
            string input = "12";
            string expectedValue = "125";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnOutput2() {
            string input = "123456789";
            string expectedValue = "1234567897";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnOutputICCID() {
            string input = "8900123490123456789";
            string expectedValue = "89001234901234567898";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void CheckLuhnOutput5()
        {
            string input = "19";
            string expectedValue = "190";
            string actualValue = luhnCandidate.AddLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CheckLuhnReturn() {
            string input = "12";
            int expectedValue = 5;
            int actualValue = luhnCandidate.ReturnLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnReturn2() {
            string input = "123456789";
            int expectedValue = 7;
            int actualValue = luhnCandidate.ReturnLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnReturnICCID() {
            string input = "8900123490123456789";
            int expectedValue = 8;
            int actualValue = luhnCandidate.ReturnLuhnSuffix(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnValidation() {
            string input = "125";
            bool expectedValue = true;
            bool actualValue = luhnCandidate.CheckLuhnSuffixReturnBool(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnValidation2() {
            string input = "1234567897";
            bool expectedValue = true;
            bool actualValue = luhnCandidate.CheckLuhnSuffixReturnBool(input);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CheckLuhnValidation3() {
            string input = "1234567899";
            bool expectedValue = false;
            bool actualValue = luhnCandidate.CheckLuhnSuffixReturnBool(input);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void CheckLuhnValidationICCID() {
            string input = "89001234901234567898";
            bool expectedValue = true;
            bool actualValue = luhnCandidate.CheckLuhnSuffixReturnBool(input);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}