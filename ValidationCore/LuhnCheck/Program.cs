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

            Console.WriteLine("Please choose an option from the following:\n" +
                "Generate [n]ew checksum\n" +
                "[R]eturn check digit\n" +
                "[V]alidate existing checksum\n" +
                "[Q]uit");
            string option = Console.ReadLine();
            switch (option) { 
                case "N":
                case "n":
                    Console.WriteLine("Please enter number requiring new checksum:");
                    input = Console.ReadLine();
                    Console.WriteLine("New checksum is " + luhnValidator.AddLuhnSuffix(input));
                    break;
                case "R":
                case "r":
                    Console.WriteLine("Please enter number for check digit:");
                    input = Console.ReadLine();
                    Console.WriteLine($"The check digit for {input} is " + luhnValidator.ReturnLuhnSuffix(input));
                    break;
                case "V":
                case "v":
                    Console.WriteLine("Please enter number requiring checksum validation:");
                    input = Console.ReadLine();
                    string result = luhnValidator.CheckLuhnSuffix(input) ? "valid" : "not valid";
                    Console.WriteLine($"Checksum is {result}.");
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Exiting application.");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No valid option selected.");
                    break;
            }
        }
    }
}
