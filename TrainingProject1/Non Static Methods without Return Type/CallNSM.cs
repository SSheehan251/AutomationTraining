using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Static_Methods_without_Return_Type
{
    class CallNSM
    {

        static void Main(string[] args)
        {
            TwoFunction t = new TwoFunction();

            t.func1();
            t.func2();

        }
    }
}
