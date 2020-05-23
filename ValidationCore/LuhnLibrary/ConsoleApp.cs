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

        private enum ValidationType
        {
            NotChosen,
            NewChecksum,
            ReturnCheckDigit,
            ValidateExistingChecksum,
        }
        private ValidationType SetValidationType(string option) {
            ValidationType validationType;
            if (option == "N" || option == "n")
                validationType = ValidationType.NewChecksum;
            if (option == "R" || option == "r")
                validationType = ValidationType.ReturnCheckDigit;
            if (option == "V" || option == "v")
                validationType = ValidationType.ValidateExistingChecksum;
            else
                validationType = ValidationType.NotChosen;
            return validationType;
        }
        private string SetUserPrompt(ValidationType validationType) {
            string userMessage;
            if (validationType == ValidationType.NewChecksum)
                userMessage = "Please enter number requiring new checksum:";
            if (validationType == ValidationType.ReturnCheckDigit)
                userMessage = "Please enter number for check digit:";
            if (validationType == ValidationType.ValidateExistingChecksum)
                userMessage = "Please enter number requiring checksum validation:";
            else
                userMessage = "No valid option selected.";
            return userMessage;
        }

        private string TakeInput(string userMessage) {
            Console.WriteLine($"{userMessage}");
            string input = Console.ReadLine();
            return input;
        }

        private void RunValidation(ValidationType validationType, string input) {
            if (validationType == ValidationType.NewChecksum)
                Console.WriteLine("New checksum is " + luhnValidator.AddLuhnSuffix(input));
            if (validationType == ValidationType.ReturnCheckDigit)
                Console.WriteLine($"The check digit for {input} is " + luhnValidator.ReturnLuhnSuffix(input));
            if (validationType == ValidationType.ValidateExistingChecksum)
                Console.WriteLine($"Checksum is " + luhnValidator.CheckLuhnSuffixReturnString(input) + ".");
        }

        public void RunApplication() {
            Console.WriteLine("Please choose an option from the following:\n" +
                "[N]ew checksum\n" +
                "[R]eturn check digit\n" +
                "[V]alidate existing checksum" //\n" +
                // "[Q]uit"
            );

            var option = Console.ReadLine();
            var validationType = SetValidationType(option);
            var userMessage = SetUserPrompt(validationType);
            var input = TakeInput(userMessage);
            RunValidation(validationType, input);
        }
    }
}
