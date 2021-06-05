using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Demo2 : Demo1
    {
        public override void fun1()
        {
            Console.WriteLine("This is First Function");
        }

        public override void fun3()
        {
            Console.WriteLine("This is Third Function");
        }
    }
}
