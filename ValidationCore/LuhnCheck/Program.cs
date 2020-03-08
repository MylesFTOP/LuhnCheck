using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LuhnLibrary;

namespace LuhnCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Start with calculating Luhn check digit for a string that doesn't have one
            // Luhn algorithm: starting from the right, take every other digit and double it, then add it all together

            string input = Console.ReadLine();
            LuhnValidator luhnValidator = new LuhnValidator();
            luhnValidator.AddLuhnSuffix(input);
        }
    }
}
