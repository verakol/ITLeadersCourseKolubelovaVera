using System;

namespace ConsoleApp.CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program that calculates sum of three numbers 
            Console.WriteLine("Program1: Calculates sum");
            int a = 5;
            int b = 2;
            int c = 8;
            int sum = a + b + c;
            Console.WriteLine("a=" + a +";" +" "+ "b=" + b +";" +" " + "c="  + c);
            Console.WriteLine("sum=" + sum);
            Console.WriteLine();

            //A program that prints perimeter and area of circle with knowns radius
            Console.WriteLine("Program2: Circle perimeter and area calculating");
            double radius = 3.5;
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine("Circle radius = " + radius);
            Console.WriteLine("Circle area = " + area);
            Console.WriteLine("Circle perimeter = " + perimeter);

        }
    }
}
