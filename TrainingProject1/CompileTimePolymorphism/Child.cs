using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimePolymorphism
{
    public class Child : Parent
    {
        public void fun3()
        {
            Console.WriteLine("This si the first function of the Child Class");
        }

        public void fun4()
        {
            Console.WriteLine("This is second function of the Child Class");
        }
    }
}
