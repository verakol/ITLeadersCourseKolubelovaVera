﻿using ConsoleApp.CSharpBasics.Classes;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.CSharpBasics
{

    class Program
    {
        static void Main(string[] args)
        {
            Person[] personsArray =
            {
                new Person("Jack"),
                new Person("Silvia"),
                new Person("Fred")
            };

            PhoneNumbers[] phoneNumbersArray =
            {
                new PhoneNumbers("380254521474"),
                new PhoneNumbers("380254254789"),
                new PhoneNumbers("380741122545")
            };


            foreach (var phoneNumbers in phoneNumbersArray)

            {
                Out.WriteLine(phoneNumbers.GetPhoneNumber());
            }
        }
    }
}
