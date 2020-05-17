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
            string input = "";
            LuhnValidator luhnValidator = new LuhnValidator();

            Console.WriteLine("Generate [n]ew checksum or [v]alidate existing checksum?");
            string option = Console.ReadLine();
            switch (option) { 
                case "N":
                case "n":
                    Console.WriteLine("Please enter number requiring new checksum:");
                    input = Console.ReadLine();
                    Console.WriteLine("New checksum is " + luhnValidator.AddLuhnSuffix(input));
                    break;
                case "V":
                case "v":
                    Console.WriteLine("Please enter number requiring checksum validation:");
                    input = Console.ReadLine();
                    string result = luhnValidator.CheckLuhnSuffix(input) ? "valid" : "not valid";
                    Console.WriteLine($"Checksum is {result}.");
                    break;
                default:
                    Console.WriteLine("No valid option selected.");
                    break;
            }
        }
    }
}
