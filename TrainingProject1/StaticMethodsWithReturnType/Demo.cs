using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsWithReturnType
{
    class Demo

    {
        static void Main(string[] args)
        {
            int d = Sample.function1();

            Console.WriteLine("ID of the Person = " + d);

            string g = Sample.function2();

            Console.WriteLine("Name of the Person = " + g);
        }
    }
}
