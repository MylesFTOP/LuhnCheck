using LuhnLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnCheck
{
    public class ConsoleUI
    {
        readonly LuhnValidator luhnValidator = new LuhnValidator();

        public void RunApplication() {
            DisplayOptions();
            var option = TakeOptionInputFromUser();
            var validationOption = SetValidationOption(option);
            var input = PromptUserForInputString(validationOption);
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
            if ( option == "N" ) 
                { validationOption = ValidationOption.NewChecksum; }
            else if ( option == "R" ) 
                { validationOption = ValidationOption.ReturnCheckDigit; }
            else if ( option == "V" ) 
                { validationOption = ValidationOption.ValidateExistingChecksum; }
            else if ( option == "Q" )
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

        private string PromptUserForInputString(in ValidationOption validationOption) {
            var userMessage = SetUserPrompt(validationOption);
            Console.WriteLine($"{userMessage}");

            if ( validationOption == ValidationOption.NotChosen ) {
                RunApplication();
                return null;
            }
            else { 
                string input = Console.ReadLine();
                return input;
            }
        }

        private string TakeOptionInputFromUser() {
            string option = Console.ReadLine().ToUpper();
            return option;
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
            var option = TakeOptionInputFromUser();

            if ( option == "Y" )
                { RunApplication(); }
            else if ( option == "N" )
                { ExitProgram(); }
            else { 
                Console.WriteLine("Option not recognised. Please try again.");
                ContinueProgram();
            }
        }
    }
}
