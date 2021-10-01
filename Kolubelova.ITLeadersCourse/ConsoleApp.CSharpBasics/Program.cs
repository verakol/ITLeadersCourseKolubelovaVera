﻿using System;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.CSharpBasics
    {
    class Program
    {
        static void Main(string[] args)
        {
            //A program that calculates sum of three numbers 
            Out.WriteLine("Program1: Calculates sum");
            int a = 5;
            int b = 2;
            int c = 8;
            int sum = a + b + c;
            Out.WriteLine("a=" + a +";" +" "+ "b=" + b +";" +" " + "c="  + c);
            Out.WriteLine("sum=" + sum);
            Out.WriteLine();

            //A program that prints perimeter and area of circle with knowns radius
            Out.WriteLine("Program2: Circle perimeter and area calculating");
            double radius = 3.5;
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * radius * Math.PI;
            Out.WriteLine("Circle radius = " + radius);
            Out.WriteLine("Circle area = " + area);
            Out.WriteLine("Circle perimeter = " + perimeter);

        }
    }
}
