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
            string inputString = "8912345678901234567";

            void ParseInputString()
            {
                bool parseSucceeded = false;
                decimal parsedOutput = 0;

                Console.WriteLine(inputString);
                
                try
                {
                    if (decimal.TryParse(inputString, out parsedOutput) == false)
                    {
                        string msg = "Input must be a number.";
                        throw new FormatException(msg);
                    }
                    parseSucceeded = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(parsedOutput);
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
            Input Input = new Input();

            Input.inputs.Add(new Input { InputString = "432529684" });
            Input.inputs.Add(new Input { InputString = "876534250" });
            Input.inputs.Add(new Input { InputString = "768943609" });

            foreach (var input in Input.inputs)
            {
                //Input.ParseInputString();

                Console.WriteLine($"InputString = {Input.InputString}");
                Console.WriteLine($"ValidInput = {Input.ValidInput}");
                Console.WriteLine($"ValidLuhn = {Input.ValidLuhn}");
            }
        }

        private static void TestTheData()
        {
            // Input.EchoInput();

            foreach (var input in Input.inputs)
            {
                Input Input = new Input();

                Input.ParseInputString();

                Console.WriteLine($"InputString = {Input.InputString}");
                Console.WriteLine($"ValidInput = {Input.ValidInput}");
                Console.WriteLine($"ValidLuhn = {Input.ValidLuhn}");
            }
            
        }
    }
}
