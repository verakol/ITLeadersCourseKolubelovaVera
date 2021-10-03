using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.CSharpBasics.IO.Implementations;
using ConsoleApp.CSharpBasics.IO.Interfaces;

namespace ConsoleApp.CSharpBasics.IO
{
    public class Input
    {
        private static IInput input;

        public static IInput In
        {
            get
            {
                if (input == null)
                {
                    input = new InputFactory().GetInputInstance(typeof(ConsoleInput));
                }

                return input;
            }
        }
    }
}
