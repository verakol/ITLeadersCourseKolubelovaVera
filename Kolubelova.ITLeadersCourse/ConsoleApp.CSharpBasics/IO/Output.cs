﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasics.IO
{
    using ConsoleApp.CSharpBasics.IO.Implementations;
    using ConsoleApp.CSharpBasics.IO.Interfaces;
    public class Output
    {
        private static IOutput output;

        public static IOutput Out
        {
            get
            {
                if (output == null)
                {
                    output = new OutputFactory().GetOutputInstance(typeof(ConsoleOutput));
                }

                return output;
            }
        }
    }
}
