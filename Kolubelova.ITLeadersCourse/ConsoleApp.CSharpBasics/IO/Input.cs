using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasics.IO
{
    using ConsoleApp.CSharpBasics.IO.Implementations;
    using ConsoleApp.CSharpBasics.IO.Interfaces;

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
