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
            ParsableInput ParseInput = new ParsableInput();
            ValidatableInput Validate = new ValidatableInput();

            Console.WriteLine("Enter number for validation:");
            ParseInput.InputString = Console.ReadLine();

            // Validate.ValidateInputString();
            // Console.WriteLine($"{ParseInput.ValidInput}");
            ParseInput.ParseInputString();

            Console.WriteLine($"{ParseInput.InputString}");
            Console.WriteLine($"{ParseInput.ValidInput}");
            Console.WriteLine($"{Validate.ValidLuhn}");
        }        
    }
}
