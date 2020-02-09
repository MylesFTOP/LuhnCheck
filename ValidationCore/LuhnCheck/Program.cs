using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LuhnLibrary;

namespace LuhnCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = ".89123456789012345670";

            void ParseInputString()
            {
                bool parseSucceeded = false;
                decimal parsedInput = 0;

                Console.WriteLine(inputString);
                
                try
                {
                    // Uses decimal as ICCIDs can be up to 70 bits long
                    if (decimal.TryParse(inputString, out parsedInput) == false)
                    {
                        string msg = "Input must be a number.";
                        throw new FormatException(msg);
                    }
                    if (inputString.IndexOf('.') >= 0)
                    {
                        string msg = "Input must not be a decimal.";
                        throw new FormatException(msg);
                    }
                    parseSucceeded = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(parsedInput);
                Console.WriteLine(parseSucceeded);
            }

            ParseInputString();

            inputString = "89123456789012345678";

            ParseInputString();

            //CollectManualInput();
            //SetupTestData();
            // Input.EchoInput();
            // Input.ParseInputString();
            //TestTheData();

        }

        private static void CollectManualInput()
        {
            Console.WriteLine("Enter number for validation:");
            Input.inputs.Add(new Input { InputString = Console.ReadLine() });
        }

        private static void SetupTestData()
        {
            var Input = new Input();

            Input.inputs.Add(new Input { InputString = "432529684" });
            Input.inputs.Add(new Input { InputString = "876534250" });
            Input.inputs.Add(new Input { InputString = "768943609" });
        }

        private static void TestTheData()
        {
            // Input.EchoInput();

            foreach (var input in Input.inputs)
            {
                //Input.ParseInputString();

                Console.WriteLine($"InputString = {Input.InputString}");
                Console.WriteLine($"ValidInput = {LuhnValidation.ValidInput}");
                Console.WriteLine($"ValidLuhn = {LuhnValidation.ValidLuhn}");
            }

        }
    }
}
