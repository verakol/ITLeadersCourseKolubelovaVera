using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.CSharpBasics.IO.Interfaces;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class InputFactory : IInputFactory
    {
        public override IInput GetInputInstance(Type inputType)
        {
            switch (inputType)
            {
                case Type when inputType == typeof(ConsoleInput):
                    return new ConsoleInput();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
