using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnLibrary
{
    public class ConsoleApp
    {
        readonly LuhnValidator luhnValidator = new LuhnValidator();

        public void RunApplication() {
            DisplayOptions();
            var option = Console.ReadLine();
            var validationOption = SetValidationOption(option);
            var userMessage = SetUserPrompt(validationOption);
            var input = TakeInput(userMessage);
            RunValidation(validationOption, input);
            ContinueProgram();
        }

        private static void DisplayOptions() {
            Console.WriteLine("Please choose an option from the following:\n" +
                            "[N]ew checksum\n" +
                            "[R]eturn check digit\n" +
                            "[V]alidate existing checksum\n" +
                            "[Q]uit");
        }

        private enum ValidationOption {
            NotChosen,
            NewChecksum,
            ReturnCheckDigit,
            ValidateExistingChecksum,
        }
        
        private ValidationOption SetValidationOption(in string option) {
            ValidationOption validationOption = ValidationOption.NotChosen;
            if (option == "N" || option == "n" ) 
                { validationOption = ValidationOption.NewChecksum; }
            else if (option == "R" || option == "r") 
                { validationOption = ValidationOption.ReturnCheckDigit; }
            else if (option == "V" || option == "v") 
                { validationOption = ValidationOption.ValidateExistingChecksum; }
            else if ( option == "Q" || option == "q" )
                { ExitProgram(); }
            return validationOption;
        }

        private static void ExitProgram() {
            System.Environment.Exit(0);
        }

        private string SetUserPrompt(in ValidationOption validationOption) {
            string userMessage;
            if (validationOption == ValidationOption.NewChecksum) 
                { userMessage = "Please enter number requiring new checksum:"; }
            else if (validationOption == ValidationOption.ReturnCheckDigit) 
                { userMessage = "Please enter number for check digit:"; }
            else if (validationOption == ValidationOption.ValidateExistingChecksum) 
                { userMessage = "Please enter number requiring checksum validation:"; }
            else 
                { userMessage = "No valid option selected."; }
            return userMessage;
        }

        private string TakeInput(in string userMessage) {
            Console.WriteLine($"{userMessage}");
            string input = Console.ReadLine();
            return input;
        }

        private void RunValidation(in ValidationOption validationOption, string input) {
            if (validationOption == ValidationOption.NewChecksum) 
                { Console.WriteLine("New checksum is " + luhnValidator.AddLuhnSuffix(input)); }
            else if (validationOption == ValidationOption.ReturnCheckDigit)
                { Console.WriteLine($"The check digit for {input} is " + luhnValidator.ReturnLuhnSuffix(input)); }
            else if (validationOption == ValidationOption.ValidateExistingChecksum)
                { Console.WriteLine($"Checksum is " + luhnValidator.CheckLuhnSuffixReturnString(input) + "."); }
        }

        private void ContinueProgram() {
            Console.WriteLine("Do you wish to validate another number (Y/N)?");
            var option = Console.ReadLine();

            if (option == "Y" || option == "y")
                { RunApplication(); }
            else if (option == "N" || option == "n")
                { ExitProgram(); }
            else { 
                Console.WriteLine("Option not recognised. Please try again.");
                ContinueProgram();
            }
        }
    }
}
