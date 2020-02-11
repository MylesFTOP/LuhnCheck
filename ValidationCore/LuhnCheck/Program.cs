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
            LuhnValidationCandidate TrueCandidate = new LuhnValidationCandidate(true);
            Console.WriteLine("Already has check digit:" + TrueCandidate.AlreadyHasCheckDigit);
            TrueCandidate.inputString = Console.ReadLine();
            TrueCandidate.ValidInput = true;
            TrueCandidate.ValidateInputString();
            Console.WriteLine(TrueCandidate.ValidLuhn);
            
            LuhnValidationCandidate FalseCandidate = new LuhnValidationCandidate(false);
            Console.WriteLine("Already has check digit:" + TrueCandidate.AlreadyHasCheckDigit);
            FalseCandidate.inputString = Console.ReadLine();
            FalseCandidate.ValidInput = true;
            FalseCandidate.ValidateInputString();
            Console.WriteLine(FalseCandidate.ValidLuhn);
        }

    }
}
