
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

        }

        #if CONDITION1
        //[Conditional("CONDITION1")]
        public static void Method1(int x)
        {
            Console.WriteLine("CONDITION1 is defined");
        }
        #endif

        #if CONDITION1 && CONDITION2
        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        public static void Method2()
        {
            Console.WriteLine("CONDITION1 or CONDITION2 is defined");
        }
        #endif

    }
}
