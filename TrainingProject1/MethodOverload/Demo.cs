using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class Demo
    {
       static void Main(string[] srgs)
        {
            Sample s = new Sample();
            s.function1(1);
            s.function1("Sinead Sheehan");
            s.function1(5, "letter");
        }

    }
}
