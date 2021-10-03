using System;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.CSharpBasics.IO.Input;

namespace ConsoleApp.CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int actualInteger = 15;

            Out.Write("Input any integer: ");
            int Integer;
            Integer = int.Parse(In.ReadLine());

            switch (Integer)
            {
                case < 10:
                case > 20:
                    Out.WriteLine("Your integer is out of range!");
                    break;
                case < 15:
                    Out.WriteLine("You are wrong! Your number is less!");
                    break;
                case > 15:
                    Out.WriteLine("You are wrong! Your number is greater!");
                    break;

                case int:
                    Out.WriteLine("Correct! This is { actualInteger}");
            }
        }
    }
}