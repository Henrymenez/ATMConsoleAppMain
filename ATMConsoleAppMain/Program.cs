﻿using System;
using ATMConsoleAppMain;
namespace ATMConsoleAppMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMFunctionalities aTMFunctionalities = new ATMFunctionalities();
            aTMFunctionalities.Run();
           
        }
    }
}