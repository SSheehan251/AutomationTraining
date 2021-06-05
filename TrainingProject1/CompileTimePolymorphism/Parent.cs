using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimePolymorphism
{
    public class Parent
    {
        public void fun1()
        {
            Console.WriteLine("This is the first function of the Parent Class");
        }

        public void fun2()
        {
            Console.WriteLine("This is the second function of the Parent Class");
        }
    }
}
