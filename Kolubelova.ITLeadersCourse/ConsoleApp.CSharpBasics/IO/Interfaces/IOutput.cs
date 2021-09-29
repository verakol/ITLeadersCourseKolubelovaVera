using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasics.IO.Interfaces
{
    public interface IOutput
    {
        void Write(object output = null);

        void WriteLine(object output = null);
    }
}
