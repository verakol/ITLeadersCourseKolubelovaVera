using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.CSharpBasics.IO.Interfaces;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class ConsoleInput : IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
