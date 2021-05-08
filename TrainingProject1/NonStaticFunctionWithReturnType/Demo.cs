using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticFunctionWithReturnType
{
   public class Demo

    {
        public static void Main(String[] args)
        {
            Sample s = new Sample();
            int f = s.fun1();
            Console.WriteLine("id of the person==" + f);
            string h = s.fun2();
            Console.WriteLine("name of the person==" + h);
        }

    }
}
