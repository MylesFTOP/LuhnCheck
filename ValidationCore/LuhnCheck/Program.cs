using System;
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
            SetupTestData();
            // CollectManualInput();
            // Input.EchoInput();
            TestTheData();
        }

        private static void CollectManualInput()
        {
            Console.WriteLine("Enter number for validation:");
            Input.inputs.Add(new Input { InputString = Console.ReadLine() });
        }

        private static void SetupTestData()
        {
            Input.inputs.Add(new Input { InputString = "432529684" });
            Input.inputs.Add(new Input { InputString = "876534250" });
            Input.inputs.Add(new Input { InputString = "768943609" });
        }

        private static void TestTheData()
        {
            Input.EchoInput();

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
