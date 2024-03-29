﻿using LuhnLibrary;
using System;
using System.Collections.Generic;

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
        
        private ValidationOption SetValidationOption(string option) {
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

        private string SetUserPrompt(ValidationOption validationOption) {
            switch (validationOption) {
                case ValidationOption.NotChosen:
                    return "Please enter number requiring new checksum:";
                case ValidationOption.NewChecksum:
                    return "Please enter number for check digit:";
                case ValidationOption.ReturnCheckDigit:
                    return "Please enter number requiring check digit:";
                case ValidationOption.ValidateExistingChecksum:
                    return "Please enter number requiring checksum validation:";
                default:
                    return "No valid option selected.";
            }
        }

        private string PromptUserForInputString(ValidationOption validationOption) {
            Console.WriteLine($"{SetUserPrompt(validationOption)}");

            if ( validationOption == ValidationOption.NotChosen ) {
                RunApplication();
                return null;
            }
            else {
                var validInput = false;
                while (!validInput)
                {
                    var input = Console.ReadLine();
                    validInput = Int32.TryParse(input, out int validatedInput);
                    if (validInput)
                    {
                        return validatedInput.ToString();
                    }
                    Console.WriteLine("Input not recognised as a number. Please try again.");
                    continue;
                }
                return null;
            }
        }

        private string TakeOptionInputFromUser() {
            return Console.ReadLine().ToUpper();
        }

        private void RunValidation(ValidationOption validationOption, string input) {
            Dictionary<ValidationOption, string> responses = new Dictionary<ValidationOption, string>()
            {
                { ValidationOption.NewChecksum , "New checksum is " + luhnValidator.AddLuhnSuffix(input) },
                { ValidationOption.ReturnCheckDigit , $"The check digit for {input} is " + luhnValidator.CalculateLuhnSuffix(input) },
                { ValidationOption.ValidateExistingChecksum , $"Checksum is " + luhnValidator.CheckLuhnSuffixReturnString(input) + "." }
            };
            responses.TryGetValue(validationOption, out string display);
            Console.WriteLine(display);
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
