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
        private static List<Input> inputs = new List<Input>();

        static void Main(string[] args)
        {
            CollectManualInput();
            EchoInput();
        }

        private static void CollectManualInput()
        {
            Console.WriteLine("Enter number for validation:");
            inputs.Add(new Input { InputString = Console.ReadLine() });
        }

        private static void SetupTestData()
        {
            inputs.Add(new Input { InputString = "432529684" });
            inputs.Add(new Input { InputString = "876534250" });
            inputs.Add(new Input { InputString = "768943609" });
        }

        private static void EchoInput()
        {
            foreach (var input in inputs)
            {
                Console.WriteLine($"You have entered the following number: {input.InputString}");
            }
        }

        private static void TestTheData()
        {
            foreach (var input in inputs)
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
