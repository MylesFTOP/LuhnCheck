using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class ConsoleApp
    {
        public void RunApplication() {
            string input;
            LuhnValidator luhnValidator = new LuhnValidator();

            Console.WriteLine("Please choose an option from the following:\n" +
                "[N]ew checksum\n" +
                "[R]eturn check digit\n" +
                "[V]alidate existing checksum\n" +
                "[Q]uit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "N":
                case "n":
                    input = TakeInput("Please enter number requiring new checksum");
                    Console.WriteLine("New checksum is " + luhnValidator.AddLuhnSuffix(input));
                    break;
                case "R":
                case "r":
                    input = TakeInput("Please enter number for check digit");
                    Console.WriteLine($"The check digit for {input} is " + luhnValidator.ReturnLuhnSuffix(input));
                    break;
                case "V":
                case "v":
                    input = TakeInput("Please enter number requiring checksum validation");
                    Console.WriteLine($"Checksum is " + luhnValidator.CheckLuhnSuffixReturnString(input) + ".");
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
        private string TakeInput(string userMessage) {
            Console.WriteLine($"{userMessage}:");
            string input = Console.ReadLine();
            return input;
        }
    }
}
