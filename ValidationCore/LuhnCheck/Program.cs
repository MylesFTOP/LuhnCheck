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
            Validate Input = new Validate();

            Console.WriteLine("Enter number for validation:");
            Input.InputString = Console.ReadLine();

            Console.WriteLine();
        }
    }
}
