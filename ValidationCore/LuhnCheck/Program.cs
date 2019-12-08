﻿using System;
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
            string inputstring = "4325325";
            Console.WriteLine(inputstring);

            decimal parsedOutput = 0;
            string msg = "";
            bool parseSucceeded = false;

            void ParseInputString()
            {
                try
                {
                    if (decimal.TryParse(inputstring, out parsedOutput) == false)
                    {
                        msg = "\nInput must be a number.";
                        throw new FormatException(msg);
                    }
                    parseSucceeded = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            ParseInputString();

            Console.WriteLine(parsedOutput);
            Console.WriteLine(parseSucceeded);

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
