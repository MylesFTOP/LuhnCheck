using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuhnLibrary;

namespace LuhnCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseInput ParseInput = new ParseInput();

            Console.WriteLine("Enter number for validation:");
            ParseInput.InputString = Console.ReadLine();
            ParseInput.ParseInputString();

            Console.WriteLine($"{ParseInput.ValidInput}");
        }
    }
}
