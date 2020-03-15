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
            // string input = Console.ReadLine();
            string input = "7992739871";
            LuhnValidator luhnValidator = new LuhnValidator();
            Console.WriteLine(luhnValidator.AddLuhnSuffix(input));
        }
    }
}
