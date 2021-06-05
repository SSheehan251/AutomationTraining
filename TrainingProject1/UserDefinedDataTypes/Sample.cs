using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationship
{
    public class Sample
    {
        private int i = 10;
        private Demo1 d;

        public Sample ()
        {
            d = new Demo1();
            d.fun1();
            d.fun2();
        }

        public void fun3()
        {
            Console.WriteLine(i);
        }
    }
}
