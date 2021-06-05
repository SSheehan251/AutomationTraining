using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrding
{
    public class Sample
    {
        static void Main(string[] args)
        {
            Child c = new Child();

            c.fun1();
            c.fun2();
        }
    }
}
