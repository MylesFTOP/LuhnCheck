﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LuhnLibrary;

namespace LuhnCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with calculating Luhn check digit for a string that doesn't have one
            // Luhn algorithm: starting from the right, take every other digit and double it, then add it all together

            string input = "12";
            int luhnDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int singleOperands = 0;
                int doubleOperands = 0;

                int currentDigit = int.Parse(input.Substring(input.Length - i - 0, 1));

                if(i % 2 == 0) // If i is an odd number
                    { singleOperands = singleOperands + currentDigit; }
                else
                    { doubleOperands = doubleOperands + currentDigit; }

                luhnDigit = singleOperands + (2 * doubleOperands); 
            }

            string output = input + luhnDigit;
            Console.WriteLine(output);
        }

    }
}
