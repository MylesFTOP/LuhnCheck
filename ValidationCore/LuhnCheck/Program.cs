﻿using System;
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
            LuhnValidationCandidate Candidate = new LuhnValidationCandidate();
            Candidate.inputString = Console.ReadLine();
            Candidate.ValidInput = true;
            Candidate.ValidateInputString();
            Console.WriteLine(Candidate.ValidLuhn);
        }

    }
}
