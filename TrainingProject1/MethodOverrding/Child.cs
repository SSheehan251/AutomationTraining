using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrding
{
    public class Child : Parent
    {

        public override void fun1()
        {
            Console.WriteLine("This is the first function of the Child Class");

        }

        public override void fun2()
        {
            Console.WriteLine("This is the secoond function of the Child Class");
        }
    }
}
